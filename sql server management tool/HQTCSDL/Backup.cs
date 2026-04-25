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
using static System.Net.WebRequestMethods;

namespace HQTCSDL
{
	public partial class Backup : Form
	{
		public Backup()
		{
			InitializeComponent();

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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Backup_Load(object sender, EventArgs e)
		{
			//Authentication
			cbAuthen.Items.Add("Windows Authentication");
			cbAuthen.Items.Add("SQL Server Authentication");
			//Component
			cbBackupCpnt.Items.Add("Database");
			cbBackupCpnt.Items.Add("Filegroups");
			//Backup type
			cbBackupType.Items.Add("Full");
			cbBackupType.Items.Add("Differential");
			cbBackupType.Items.Add("Transaction Log");

			// Đặt giá trị mặc định (tùy chọn)
			cbAuthen.SelectedIndex = 0;
			cbBackupType.SelectedIndex = 0;
			cbBackupCpnt.SelectedIndex = 0;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
				lbPassword.Enabled= true;
				lbUsername.Enabled = true;
			}
		}

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				folderBrowserDialog.Description = "Chọn thư mục để lưu file backup"; // Mô tả hộp thoại

				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					// Lưu đường dẫn thư mục đã chọn vào TextBox tbPath
					tbPath.Text = folderBrowserDialog.SelectedPath;
				}
			}
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if (cbDatabase.SelectedIndex == -1)
            //{
            //	MessageBox.Show("Vui lòng chọn cơ sở dữ liệu để sao lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //	return;
            //}

            //string database = cbDatabase.Text.Trim();
            //string filePath = tbPath.Text.Trim();
            //string fileName = tbFileName.Text.Trim();
            //string serverName = tbServer.Text.Trim();
            //string authType = cbAuthen.SelectedItem?.ToString();
            //string connectionString = "";

            //// Kiểm tra đầu vào
            //if (string.IsNullOrWhiteSpace(filePath) || string.IsNullOrWhiteSpace(fileName))
            //{
            //	MessageBox.Show("Vui lòng nhập đầy đủ đường dẫn và tên file sao lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //	return;
            //}

            //if (string.IsNullOrWhiteSpace(serverName))
            //{
            //	MessageBox.Show("Vui lòng nhập tên máy chủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //	return;
            //}

            //if (authType == "Windows Authentication")
            //{
            //	connectionString = $"Server={serverName};Integrated Security=True;";
            //}
            //else if (authType == "SQL Server Authentication")
            //{
            //	string user = tbUsername.Text.Trim();
            //	string pass = tbPassword.Text;

            //	if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            //	{
            //		MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //		return;
            //	}

            //	connectionString = $"Server={serverName};User ID={user};Password={pass};";
            //}
            //else
            //{
            //	MessageBox.Show("Vui lòng chọn phương thức xác thực.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //	return;
            //}

            //if (!fileName.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
            //{
            //	fileName += ".bak";
            //}
            //string fullBackupPath = Path.Combine(filePath, fileName);

            //try
            //{
            //	using (SqlConnection connection = new SqlConnection(connectionString))
            //	{
            //		connection.Open();

            //		// 🔐 Kiểm tra quyền BACKUP DATABASE
            //		string checkPermissionQuery = "SELECT HAS_PERMS_BY_NAME(@dbName, 'DATABASE', 'BACKUP DATABASE');";
            //		using (SqlCommand checkCmd = new SqlCommand(checkPermissionQuery, connection))
            //		{
            //			checkCmd.Parameters.AddWithValue("@dbName", database);
            //			int hasPermission = (int)checkCmd.ExecuteScalar();
            //			if (hasPermission == 0)
            //			{
            //				MessageBox.Show("Tài khoản hiện tại không có quyền sao lưu cơ sở dữ liệu!", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //				return;
            //			}
            //		}

            //		// 🗄️ Thực hiện sao lưu
            //		string backupQuery = $"BACKUP DATABASE [{database}] TO DISK = N'{fullBackupPath}' WITH INIT, FORMAT";
            //		using (SqlCommand backupCmd = new SqlCommand(backupQuery, connection))
            //		{
            //			backupCmd.ExecuteNonQuery();
            //			MessageBox.Show("Sao lưu cơ sở dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //		}
            //	}
            //}
            //catch (Exception ex)
            //{
            //	MessageBox.Show("Lỗi sao lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (cbDatabase.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn cơ sở dữ liệu để sao lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string database = cbDatabase.Text.Trim();
            string filePath = tbPath.Text.Trim();
            string fileName = tbFileName.Text.Trim();
            string serverName = tbServer.Text.Trim();
            string authType = cbAuthen.SelectedItem?.ToString();
            string backupComponent = cbBackupCpnt.SelectedItem?.ToString();
            string backupType = cbBackupType.SelectedItem?.ToString();
            string connectionString = "";

            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(filePath) || string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ đường dẫn và tên file sao lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(serverName))
            {
                MessageBox.Show("Vui lòng nhập tên máy chủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (authType == "Windows Authentication")
            {
                connectionString = $"Server={serverName};Integrated Security=True;";
            }
            else if (authType == "SQL Server Authentication")
            {
                string user = tbUsername.Text.Trim();
                string pass = tbPassword.Text;

                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connectionString = $"Server={serverName};User ID={user};Password={pass};";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức xác thực.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!fileName.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".bak";
            }
            string fullBackupPath = Path.Combine(filePath, fileName);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 🔐 Kiểm tra quyền BACKUP DATABASE
                    string checkPermissionQuery = "SELECT HAS_PERMS_BY_NAME(@dbName, 'DATABASE', 'BACKUP DATABASE');";
                    using (SqlCommand checkCmd = new SqlCommand(checkPermissionQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@dbName", database);
                        int hasPermission = (int)checkCmd.ExecuteScalar();
                        if (hasPermission == 0)
                        {
                            MessageBox.Show("Tài khoản hiện tại không có quyền sao lưu cơ sở dữ liệu!", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 🗄️ Thực hiện sao lưu
                    string backupQuery = "";
                    if (backupComponent == "Database")
                    {
                        if (backupType == "Full")
                        {
                            backupQuery = $"BACKUP DATABASE [{database}] TO DISK = N'{fullBackupPath}' WITH INIT, FORMAT";
                        }
                        else if (backupType == "Differential")
                        {
                            backupQuery = $"BACKUP DATABASE [{database}] TO DISK = N'{fullBackupPath}' WITH DIFFERENTIAL, INIT, FORMAT";
                        }
                        else if (backupType == "Transaction Log")
                        {
                            backupQuery = $"BACKUP LOG [{database}] TO DISK = N'{fullBackupPath}' WITH INIT, FORMAT";
                        }
                    }
                    else if (backupComponent == "Filegroups")
                    {
                        // Lấy danh sách filegroup từ tbFileG
                        string fileGroupsText = tbFileG.Text.Trim();
                        if (string.IsNullOrWhiteSpace(fileGroupsText))
                        {
                            MessageBox.Show("Vui lòng chọn ít nhất một filegroup để sao lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Tách danh sách filegroup (dạng "filegroup1, filegroup2, ...")
                        string[] fileGroups = fileGroupsText.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                        // Kiểm tra xem filegroup có tồn tại trong cơ sở dữ liệu không
                        foreach (string fg in fileGroups)
                        {
                            string checkFileGroupQuery = $"SELECT COUNT(*) FROM sys.filegroups WHERE name = @fileGroupName AND data_space_id IN (SELECT data_space_id FROM sys.master_files WHERE database_id = DB_ID('{database}'));";
                            using (SqlCommand checkFgCmd = new SqlCommand(checkFileGroupQuery, connection))
                            {
                                checkFgCmd.Parameters.AddWithValue("@fileGroupName", fg);
                                int count = (int)checkFgCmd.ExecuteScalar();
                                if (count == 0)
                                {
                                    MessageBox.Show($"Filegroup '{fg}' không tồn tại trong cơ sở dữ liệu '{database}'!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        // Tạo lệnh BACKUP cho từng filegroup
                        if (backupType == "Full")
                        {
                            backupQuery = $"BACKUP DATABASE [{database}] FILEGROUP = {string.Join(", FILEGROUP = ", fileGroups.Select(fg => $"N'{fg}'"))} TO DISK = N'{fullBackupPath}' WITH INIT, FORMAT";
                        }
                        else if (backupType == "Differential")
                        {
                            backupQuery = $"BACKUP DATABASE [{database}] FILEGROUP = {string.Join(", FILEGROUP = ", fileGroups.Select(fg => $"N'{fg}'"))} TO DISK = N'{fullBackupPath}' WITH DIFFERENTIAL, INIT, FORMAT";
                        }
                        else if (backupType == "Transaction Log")
                        {
                            // Transaction Log không hỗ trợ backup filegroup, thông báo lỗi
                            MessageBox.Show("Backup Transaction Log không hỗ trợ backup filegroup!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (string.IsNullOrEmpty(backupQuery))
                    {
                        MessageBox.Show("Không thể tạo lệnh sao lưu. Vui lòng kiểm tra các tùy chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlCommand backupCmd = new SqlCommand(backupQuery, connection))
                    {
                        backupCmd.CommandTimeout = 0; // Không giới hạn thời gian, đề phòng backup lâu
                        backupCmd.ExecuteNonQuery();
                        MessageBox.Show("Sao lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sao lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

		private void btnRes_Click(object sender, EventArgs e)
		{
			Restore restore = new Restore();
			restore.Show();
			this.Hide();
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

		private void lbPassword_Click(object sender, EventArgs e)
		{

		}

		private void lbUsername_Click(object sender, EventArgs e)
		{

		}

		private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedDatabase = cbDatabase.SelectedItem?.ToString();
		}

		private void tbFileName_TextChanged(object sender, EventArgs e)
		{

		}


		private void cbBackupCpnt_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedOption = cbBackupCpnt.SelectedItem.ToString();
			if (selectedOption == "Database")
			{
				lbFileG.Enabled = false;
				tbFileG.Enabled = false;
				tbFileG.Text = string.Empty;

			}
			else if (selectedOption == "Filegroups")
			{
				lbFileG.Enabled = true;
				tbFileG.Enabled = true;
				//Kết nối database và đảm bảo đúng database
				string selectedDatabase = cbDatabase.SelectedItem?.ToString();
				string connectionStr = $"Server={tbServer.Text};Database={selectedDatabase};Integrated Security=True;";

				// Mở Form Filegroups
				using (Filegroups fgForm = new Filegroups(connectionStr, selectedDatabase))
				{
					if (fgForm.ShowDialog() == DialogResult.OK)
					{
						// Lấy danh sách filegroups được chọn từ form
						List<string> selectedFileGroups = fgForm.SelectedFileGroups;

						// Hiện thị danh sách filegroups (có thể là chuỗi các tên filegroup cách nhau bởi dấu phẩy)
						tbFileG.Text = string.Join(", ", selectedFileGroups);
					}
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void lbBackUpcpnt_Click(object sender, EventArgs e)
		{

		}

		private void lbFileG_Click(object sender, EventArgs e)
		{

		}

		private void lbFilepath_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{


		}

		private void cbBackupType_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedOption = cbBackupType.SelectedItem.ToString();
			if (selectedOption == "Full")
			{
				lbFileG.Enabled = true;
				tbFileG.Enabled = true;
				lbBackUpcpnt.Enabled = true;
				cbBackupCpnt.Enabled = true;

			}
			else if (selectedOption == "Differential")
			{
				lbFileG.Enabled = true;
				tbFileG.Enabled = true;
				lbBackUpcpnt.Enabled = true;
				cbBackupCpnt.Enabled = true;

			}
			else if (selectedOption == "Transaction Log")
			{	
				//Filegruops Name
				lbFileG.Enabled = false;
				tbFileG.Enabled = false;
				tbFileG.Text = string.Empty;
				//Backup Component 
				lbBackUpcpnt.Enabled = false;
				cbBackupCpnt.Enabled = false;
				cbBackupCpnt.Text = string.Empty;

			}
		}

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
			Encrypt encrypt = new Encrypt();
			encrypt.Show();
			this.Hide();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
			Security ser = new Security();
			ser.Show();
			this.Hide();
        }
    }
}
