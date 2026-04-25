using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQTCSDL
{
	public partial class Restore : Form
	{
		public Restore()
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


        private void label2_Click(object sender, EventArgs e)
		{

		}

		private void tbPath_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSelectFile_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Backup files (*.bak)|*.bak|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = openFileDialog.FileName;
            }
        }

		private void btnRes_Click(object sender, EventArgs e)
		{
			
		}

		

		private void tbFilePath_TextChanged(object sender, EventArgs e)
		{

		}

		private void panelRestore_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Restore_Load(object sender, EventArgs e)
		{
			cbAuthen.Items.Add("Windows Authentication");
			cbAuthen.Items.Add("SQL Server Authentication");

            cbType.Items.Add("Database");
            cbType.Items.Add("FileGroups");

			// Đặt giá trị mặc định (tùy chọn)
			cbAuthen.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
            //string serverName = tbServer.Text;
            //string databaseName = cbDatabase.Text;
            //string authentication = cbAuthen.SelectedItem?.ToString();
            //string username = tbUsername.Text;
            //string password = tbPassword.Text;

            //// Chuỗi kết nối
            //string connectionString;

            //// Kiểm tra loại xác thực
            //if (authentication == "SQL Server Authentication")
            //{
            //	connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password};";
            //}
            //else if (authentication == "Windows Authentication")
            //{
            //	connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            //}
            //else
            //{
            //	MessageBox.Show("Vui lòng chọn loại xác thực!");
            //	return; 
            //}

            //// Thử kết nối
            //try
            //{
            //	using (SqlConnection connection = new SqlConnection(connectionString))
            //	{
            //		connection.Open(); // Mở kết nối
            //		MessageBox.Show("Kết nối thành công!");
            //	}
            //}
            //catch (Exception ex)
            //{
            //	MessageBox.Show($"Không thể kết nối: {ex.Message}");
            //}

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
                connectionString = $"Server={serverName};Database=master;User Id={username};Password={password};";
            }
            else if (authentication == "Windows Authentication")
            {
                connectionString = $"Server={serverName};Database=master;Integrated Security=True;";
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

		private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
		{
            string serverName = tbServer.Text;
            string authentication = cbAuthen.SelectedItem?.ToString();
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string selectedDatabase = cbDatabase.SelectedItem?.ToString();

            if (cbType.SelectedItem?.ToString() == "FileGroups")
            {
                LoadFileGroups(serverName, authentication, username, password, selectedDatabase);
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cbType.SelectedItem.ToString();
            if(selectedOption == "Database")
            {
                cbFileGroup.Enabled = false;
            }
            else
            {
                cbFileGroup.Enabled = true;

                if (cbDatabase.SelectedItem != null)
                {
                    string serverName = tbServer.Text;
                    string authentication = cbAuthen.SelectedItem?.ToString();
                    string username = tbUsername.Text;
                    string password = tbPassword.Text;
                    string databaseName = cbDatabase.SelectedItem.ToString();

                    LoadFileGroups(serverName, authentication, username, password, databaseName);
                }
            }
        }

        private void LoadFileGroups(string serverName, string authentication, string username, string password, string databaseName)
        {
            string connectionString;

            if (authentication == "SQL Server Authentication")
            {
                connectionString = $"Server={serverName};Database={databaseName};User Id={username};Password={password};";
            }
            else // Windows Authentication
            {
                connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name FROM sys.filegroups";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cbFileGroup.Items.Clear();

                        while (reader.Read())
                        {
                            cbFileGroup.Items.Add(reader["name"].ToString());
                        }

                        if (cbFileGroup.Items.Count > 0)
                            cbFileGroup.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải Filegroups: {ex.Message}");
            }
        }

        private void btnBackUpPannel_Click(object sender, EventArgs e)
        {
            string serverName = tbServer.Text;
            string databaseName = cbDatabase.Text;
            string authentication = cbAuthen.SelectedItem?.ToString();
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string backupFile = tbFilePath.Text;
            string restoreType = cbType.SelectedItem?.ToString();
            string fileGroup = cbFileGroup.SelectedItem?.ToString();
            string connectionString;

            if (authentication == "SQL Server Authentication")
            {
                connectionString = $"Server={serverName};Database=master;User Id={username};Password={password};";
            }
            else
            {
                connectionString = $"Server={serverName};Database=master;Integrated Security=True;";
            }

            if (string.IsNullOrEmpty(backupFile) || !System.IO.File.Exists(backupFile))
            {
                MessageBox.Show("File backup không tồn tại.");
                return;
            }

            try
            {
                using (var stream = new System.IO.FileStream(backupFile, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    stream.Close();
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("Không có quyền truy cập vào file backup.", "Lỗi quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra file backup: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🔥 Ngắt kết nối các session đang truy cập database
            string killConnections = $@"
    DECLARE @kill varchar(8000) = '';
    SELECT @kill = @kill + 'kill ' + CONVERT(varchar(10), session_id) + ';'
    FROM sys.dm_exec_sessions
    WHERE database_id = DB_ID('{databaseName}') AND session_id <> @@SPID;
    EXEC(@kill);";

            string sqlRestore = "";

            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();

            //        // Kiểm tra trạng thái cơ sở dữ liệu trước khi khôi phục
            //        string checkState = $"SELECT state_desc FROM sys.databases WHERE name = '{databaseName}';";
            //        string initialState;
            //        using (SqlCommand checkCmd = new SqlCommand(checkState, conn))
            //        {
            //            initialState = checkCmd.ExecuteScalar()?.ToString();
            //            if (initialState == "RESTORING")
            //            {
            //                MessageBox.Show("Cơ sở dữ liệu đang ở trạng thái RESTORING. Đang cố gắng hoàn tất khôi phục...");
            //                try
            //                {
            //                    string completeRestore = $"RESTORE DATABASE [{databaseName}] WITH RECOVERY;";
            //                    using (SqlCommand completeCmd = new SqlCommand(completeRestore, conn))
            //                    {
            //                        completeCmd.ExecuteNonQuery();
            //                    }
            //                }
            //                catch (Exception ex)
            //                {
            //                    MessageBox.Show($"Không thể hoàn tất khôi phục: {ex.Message}. Vui lòng kiểm tra SQL Server Error Log.");
            //                    return;
            //                }
            //            }
            //        }

            //        // Kiểm tra và chuyển recovery model sang SIMPLE
            //        string recoveryModelQuery = $"SELECT recovery_model_desc FROM sys.databases WHERE name = '{databaseName}';";
            //        string recoveryModel;
            //        using (SqlCommand cmd = new SqlCommand(recoveryModelQuery, conn))
            //        {
            //            recoveryModel = cmd.ExecuteScalar()?.ToString();
            //        }

            //        if (recoveryModel != "SIMPLE")
            //        {
            //            DialogResult result = MessageBox.Show(
            //                $"Cơ sở dữ liệu đang ở chế độ {recoveryModel}. Bạn có muốn chuyển sang chế độ SIMPLE để khôi phục mà không cần transaction log không? (Lưu ý: Điều này sẽ xóa các giao dịch chưa sao lưu.)",
            //                "Xác nhận",
            //                MessageBoxButtons.YesNo,
            //                MessageBoxIcon.Question
            //            );

            //            if (result == DialogResult.Yes)
            //            {
            //                string setSimpleQuery = $"ALTER DATABASE [{databaseName}] SET RECOVERY SIMPLE;";
            //                using (SqlCommand setSimpleCmd = new SqlCommand(setSimpleQuery, conn))
            //                {
            //                    setSimpleCmd.ExecuteNonQuery();
            //                }
            //                MessageBox.Show("Đã chuyển cơ sở dữ liệu sang chế độ SIMPLE.");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Khôi phục bị hủy. Vui lòng chuyển cơ sở dữ liệu sang chế độ SIMPLE hoặc chuẩn bị transaction log nếu cần.");
            //                return;
            //            }
            //        }

            //        if (restoreType == "Database")
            //        {
            //            sqlRestore = $@"
            //    USE master;
            //    ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            //    {killConnections}
            //    RESTORE DATABASE [{databaseName}] 
            //    FROM DISK = N'{backupFile}' 
            //    WITH REPLACE, RECOVERY;
            //    ALTER DATABASE [{databaseName}] SET MULTI_USER;";
            //        }
            //        else if (restoreType == "FileGroups")
            //        {
            //            if (string.IsNullOrEmpty(fileGroup))
            //            {
            //                MessageBox.Show("Vui lòng chọn filegroup để restore.");
            //                return;
            //            }

            //            string checkFileGroup = $"RESTORE FILELISTONLY FROM DISK = N'{backupFile}'";
            //            bool fileGroupExists = false;
            //            bool primaryExists = false;

            //            using (SqlCommand cmd = new SqlCommand(checkFileGroup, conn))
            //            {
            //                using (SqlDataReader reader = cmd.ExecuteReader())
            //                {
            //                    while (reader.Read())
            //                    {
            //                        string fileGroupName = reader["FileGroupName"].ToString();
            //                        if (fileGroupName == fileGroup)
            //                            fileGroupExists = true;
            //                        if (fileGroupName == "PRIMARY")
            //                            primaryExists = true;
            //                    }
            //                }
            //            }

            //            if (!primaryExists)
            //            {
            //                MessageBox.Show("Filegroup 'PRIMARY' không tồn tại trong file backup. Vui lòng sử dụng file backup chứa PRIMARY.");
            //                return;
            //            }

            //            if (!fileGroupExists)
            //            {
            //                MessageBox.Show($"Filegroup '{fileGroup}' không tồn tại trong file backup.");
            //                return;
            //            }

            //            // Nếu khôi phục PRIMARY
            //            if (fileGroup == "PRIMARY")
            //            {
            //                sqlRestore = $@"
            //        USE master;
            //        {killConnections}
            //        ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            //        RESTORE DATABASE [{databaseName}] 
            //        FILEGROUP = N'PRIMARY' 
            //        FROM DISK = N'{backupFile}' 
            //        WITH REPLACE, RECOVERY;
            //        ALTER DATABASE [{databaseName}] SET MULTI_USER;";
            //            }
            //            else
            //            {
            //                sqlRestore = $@"
            //        USE master;
            //        {killConnections}
            //        ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            //        RESTORE DATABASE [{databaseName}] 
            //        FILEGROUP = N'PRIMARY' 
            //        FROM DISK = N'{backupFile}' 
            //        WITH REPLACE, NORECOVERY;
            //        RESTORE DATABASE [{databaseName}] 
            //        FILEGROUP = N'{fileGroup}' 
            //        FROM DISK = N'{backupFile}' 
            //        WITH REPLACE, RECOVERY;
            //        ALTER DATABASE [{databaseName}] SET MULTI_USER;";
            //            }
            //        }

            //        // Thực hiện khôi phục
            //        using (SqlCommand cmd = new SqlCommand(sqlRestore, conn))
            //        {
            //            cmd.CommandTimeout = 0; // Không giới hạn thời gian
            //            cmd.ExecuteNonQuery();
            //        }

            //        // Kiểm tra trạng thái cơ sở dữ liệu sau khi khôi phục
            //        string finalState;
            //        using (SqlCommand checkCmd = new SqlCommand(checkState, conn))
            //        {
            //            finalState = checkCmd.ExecuteScalar()?.ToString();
            //            if (finalState != "ONLINE")
            //            {
            //                MessageBox.Show($"Khôi phục hoàn tất nhưng cơ sở dữ liệu vẫn ở trạng thái: {finalState}. Vui lòng kiểm tra SQL Server Error Log để biết chi tiết.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //            else
            //            {
            //                MessageBox.Show("Khôi phục thành công! Cơ sở dữ liệu hiện ở trạng thái ONLINE.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Lỗi khi thực hiện restore: " + ex.Message);
            //}

            if (restoreType == "Database")
            {
                sqlRestore = $@"
                USE master;
                ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [{databaseName}] 
                FROM DISK = N'{backupFile}' 
                WITH REPLACE;
                ALTER DATABASE [{databaseName}] SET MULTI_USER;";
            }

            else if (restoreType == "FileGroups")
            {
                if (string.IsNullOrEmpty(fileGroup))
                {
                    MessageBox.Show("Vui lòng chọn filegroup để restore.");
                    return;
                }

                sqlRestore = $@"
                USE master;
                ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                ALTER DATABASE [{databaseName}] SET MULTI_USER;
                RESTORE DATABASE [{databaseName}] 
                FILEGROUP = N'{fileGroup}' 
                FROM DISK = N'{backupFile}' 
                WITH PARTIAL, REPLACE, RECOVERY;";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlRestore, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Restore thành công!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 916 || ex.Number == 229)
                {
                    MessageBox.Show("Tài khoản hiện tại không có quyền thực hiện RESTORE.", "Lỗi phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi khi thực hiện restore: " + ex.Message);
                }
            }

        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            Encrypt en = new Encrypt();
            en.Show();
            this.Close();
        }

		private void btnSec_Click(object sender, EventArgs e)
		{
			Security ser = new Security();
			ser.Show();
			this.Hide();
		}

		//Source
		// 1) Đổi lại chữ ký của PopulateDatabaseNames để nhận đủ 5 tham số
		//private void PopulateDatabaseNames(string serverName, string authentication, string username, string password, string backupFilePath)
		//{
		//	// Build connection string tới master
		//	string connMaster = authentication == "SQL Server Authentication"
		//		? $"Server={serverName};Database=master;User Id={username};Password={password};"
		//		: $"Server={serverName};Database=master;Integrated Security=True;";

		//	// Lệnh RESTORE FILELISTONLY
		//	string sql = $"RESTORE FILELISTONLY FROM DISK = N'{backupFilePath.Replace("'", "''")}'";

		//	try
		//	{
		//		using (var conn = new SqlConnection(connMaster))
		//		using (var cmd = new SqlCommand(sql, conn))
		//		{
		//			conn.Open();
		//			DataTable dt = new DataTable();
		//			dt.Load(cmd.ExecuteReader());

		//			// Clear & add vào cbDbaSource
		//			cbbDbaSource.Items.Clear();
		//			foreach (DataRow row in dt.Rows)
		//			{
		//				cbbDbaSource.Items.Add(row["LogicalName"].ToString());
		//			}

		//			if (cbbDbaSource.Items.Count > 0)
		//				cbbDbaSource.SelectedIndex = 0;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show($"Có lỗi khi truy xuất thông tin backup: {ex.Message}",
		//						"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//}

		private void btnFilePath_Click(object sender, EventArgs e)
		{
			//using (OpenFileDialog openFileDialog = new OpenFileDialog())
			//{
			//	openFileDialog.Title = "Chọn file restore";
			//	openFileDialog.Filter = "Backup Files|*.bak|All Files|*.*"; // Chỉ hiển thị file .bak hoặc tất cả các file

			//	if (openFileDialog.ShowDialog() == DialogResult.OK)
			//	{
			//		// Lấy đường dẫn file được chọn
			//		string filePath = openFileDialog.FileName;

			//		// Hiển thị đường dẫn trong TextBox
			//		tbFilePath.Text = filePath;

			//		// Nếu cần, bạn có thể thực hiện thêm logic backup hoặc xử lý file tại đây
			//	}
			//}
			using (var dlg = new OpenFileDialog())
			{
				dlg.Title = "Chọn file restore";
				dlg.Filter = "Backup Files|*.bak";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					string filePath = dlg.FileName;
					tbFilePath.Text = filePath;

					// Load LogicalNames lên cbDbaSource
					//PopulateDatabaseNames(
					//	tbServer.Text.Trim(),
					//	cbAuthen.SelectedItem?.ToString(),
					//	tbUsername.Text.Trim(),
					//	tbPassword.Text,
					//	filePath         // đường dẫn .bak
					//);
				}
			}
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.Show();
            this.Hide();
        }
    }
}
