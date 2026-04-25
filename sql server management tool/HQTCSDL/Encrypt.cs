using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQTCSDL
{
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
        }

        private void Encrypt_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách và giá trị mặc định cho cbAuthen
            cbAuthen.Items.Add("Windows Authentication");
            cbAuthen.Items.Add("SQL Server Authentication");
            cbAuthen.SelectedIndex = 0; // Mặc định chọn Windows Authentication
        }

        private void tbServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string serverName = tbServer.Text;
            string databaseName = cbDatabase.Text;
            string authentication = cbAuthen.SelectedItem?.ToString();
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            // Chuỗi kết nối
            string connectionString;
            if (string.IsNullOrWhiteSpace(tbServer.Text))
            {
                MessageBox.Show("Vui lòng nhập Server Name!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng xử lý nếu Server Name bị bỏ trống
            }

            // Kiểm tra loại xác thực
            if (authentication == "SQL Server Authentication")
            {
                connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password};";
            }
            else if (authentication == "Windows Authentication")
            {
                connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại xác thực!");
                return;
            }

            // Thử kết nối
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Kết nối thành công!");

                    // Sau khi kết nối, tải danh sách databases
                    LoadDatabases(serverName, authentication, username, password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối: {ex.Message}");
            }
        }

        private void LoadDatabases(string serverName, string authentication, string username, string password)
        {
            string connectionString;

            // Tạo chuỗi kết nối dựa trên loại xác thực
            if (authentication == "SQL Server Authentication")
            {
                connectionString = $"Server={serverName};Database=master;User Id={username};Password={password};";
            }
            else if (authentication == "Windows Authentication")
            {
                connectionString = $"Server={serverName};Database=master;Integrated Security=True;";
            }
            else
            {
                MessageBox.Show("Loại xác thực không hợp lệ!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Kết nối với SQL Server

                    // Truy vấn danh sách cơ sở dữ liệu
                    string query = "SELECT name FROM sys.databases WHERE state = 0;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cbDatabase.Items.Clear(); // Xóa danh sách cũ trong ComboBox

                        while (reader.Read())
                        {
                            // Thêm từng database vào ComboBox
                            cbDatabase.Items.Add(reader["name"].ToString());
                        }
                    }

                    if (cbDatabase.Items.Count > 0)
                    {
                        cbDatabase.SelectedIndex = 0; // Chọn mục đầu tiên
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải danh sách cơ sở dữ liệu: {ex.Message}");
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            string server = tbServer.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string database = cbDatabase.Text;
            string masterKeyPassword = tbPE.Text;
            string certBackupPath = tbPath.Text;

            if (string.IsNullOrWhiteSpace(certBackupPath))
            {
                MessageBox.Show("Vui lòng chọn đường dẫn để lưu Certificate.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString;
            string authen = cbAuthen.SelectedItem?.ToString();
            if (authen == "SQL Server Authentication")
                connectionString = $"Server={server};Database=master;User Id={username};Password={password};";
            else
                connectionString = $"Server={server};Database=master;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra quyền sysadmin
                    string checkPermission = "SELECT IS_SRVROLEMEMBER('sysadmin')";
                    using (SqlCommand cmd = new SqlCommand(checkPermission, conn))
                    {
                        int isSysadmin = Convert.ToInt32(cmd.ExecuteScalar());
                        if (isSysadmin != 1)
                        {
                            MessageBox.Show("Tài khoản không đủ quyền để mã hóa TDE (cần quyền sysadmin).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 1. Tạo Master Key nếu chưa có
                    string checkMasterKey = "SELECT COUNT(*) FROM sys.symmetric_keys WHERE name LIKE '%DatabaseMasterKey%'";
                    using (SqlCommand cmd = new SqlCommand(checkMasterKey, conn))
                    {
                        int hasKey = Convert.ToInt32(cmd.ExecuteScalar());
                        if (hasKey == 0)
                        {
                            string createKey = $"CREATE MASTER KEY ENCRYPTION BY PASSWORD = '{masterKeyPassword}'";
                            new SqlCommand(createKey, conn).ExecuteNonQuery();
                        }
                    }

                    // 2. Tạo Certificate nếu chưa có
                    string checkCert = "SELECT COUNT(*) FROM sys.certificates WHERE name = 'MyServerCert'";
                    using (SqlCommand cmd = new SqlCommand(checkCert, conn))
                    {
                        int certCount = Convert.ToInt32(cmd.ExecuteScalar());
                        if (certCount == 0)
                        {
                            string createCert = "CREATE CERTIFICATE MyServerCert WITH SUBJECT = 'My TDE Certificate'";
                            new SqlCommand(createCert, conn).ExecuteNonQuery();

                            // Backup certificate ra file nếu chưa tồn tại
                            string cerPath = Path.Combine(certBackupPath, "MyServerCert.cer");
                            string pvkPath = Path.Combine(certBackupPath, "MyServerCert.pvk");

                            string backupCert = $@"
                            BACKUP CERTIFICATE MyServerCert 
                            TO FILE = '{cerPath}'
                            WITH PRIVATE KEY (
                            FILE = '{pvkPath}', 
                            ENCRYPTION BY PASSWORD = '{masterKeyPassword}'
                            )";
                            new SqlCommand(backupCert, conn).ExecuteNonQuery();
                        }
                    }

                    // 3. Chuyển sang database được chọn
                    new SqlCommand($"USE [{database}]", conn).ExecuteNonQuery();

                    // 4. Kiểm tra nếu database đã mã hóa thì không mã hóa lại
                    string checkTDE = "SELECT is_encrypted FROM sys.databases WHERE name = DB_NAME()";
                    using (SqlCommand cmd = new SqlCommand(checkTDE, conn))
                    {
                        int isEncrypted = Convert.ToInt32(cmd.ExecuteScalar());
                        if (isEncrypted == 1)
                        {
                            MessageBox.Show($"Database [{database}] đã được mã hóa TDE. Không cần mã hóa lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // 5. Tạo DEK nếu chưa có
                    string checkDEK = "SELECT COUNT(*) FROM sys.symmetric_keys WHERE name = '##MS_DatabaseEncryptionKey##'";
                    using (SqlCommand cmd = new SqlCommand(checkDEK, conn))
                    {
                        int dekExists = Convert.ToInt32(cmd.ExecuteScalar());
                        if (dekExists == 0)
                        {
                            string createDEK = @"
                        CREATE DATABASE ENCRYPTION KEY
                        WITH ALGORITHM = AES_256
                        ENCRYPTION BY SERVER CERTIFICATE MyServerCert";
                            new SqlCommand(createDEK, conn).ExecuteNonQuery();
                        }
                    }

                    // 6. Bật TDE
                    string enableTDE = $"ALTER DATABASE [{database}] SET ENCRYPTION ON";
                    new SqlCommand(enableTDE, conn).ExecuteNonQuery();

                    MessageBox.Show("Mã hóa TDE thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mã hóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã ở phần mã hóa","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Backup bk = new Backup();
            bk.Show();
            this.Close();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            Restore res = new Restore();
            res.Show();
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            Security sc = new Security();
            sc.Show();
            this.Close();
        }

        private void cbAuthen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cbAuthen.SelectedItem.ToString();
            if (selectedOption == "Windows Authentication")
            {
                // Làm mờ và không cho phép nhập Username và Password
                tbUsername.Enabled = false;
                tbPassword.Enabled = false;
                lbPassword.Enabled = false;
                lbUsername.Enabled = false;

                // Xóa giá trị nếu cần (tuỳ chọn)
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
            }
            else if (selectedOption == "SQL Server Authentication")
            {
                // Làm rõ và cho phép nhập Username và Password
                tbUsername.Enabled = true;
                tbPassword.Enabled = true;
                lbPassword.Enabled = true;
                lbUsername.Enabled = true;
            }
        }
    }
}
