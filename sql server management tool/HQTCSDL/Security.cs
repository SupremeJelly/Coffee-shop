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
	public partial class Security : Form
	{
		private string currentConnectionString; // Biến dùng chung
		public Security()
		{
			InitializeComponent();
			cbAuthen.Items.Add("Windows Authentication");
			cbAuthen.Items.Add("SQL Server Authentication");
			cbAuthen.SelectedIndex = 0;
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
		// Thực thi GRANT/REVOKE
		private void ExecutePermission(string action)
		{
			string username = dgvUsers.SelectedRows[0].Cells["UserName"].Value.ToString();
			string permission = cbPermissions.SelectedItem as string;

			if (string.IsNullOrEmpty(permission))
			{
				MessageBox.Show("Chọn quyền (SELECT, INSERT, ...).", "Thông báo",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string sql = null;

			switch (action)
			{
				case "GRANT":
					sql = $"GRANT {permission} TO [{username}]";
					break;
				case "DENY":
					sql = $"DENY {permission} TO [{username}]";
					break;
				case "REVOKE":
					sql = $"REVOKE {permission} FROM [{username}]";
					break;
				default:
					MessageBox.Show("Hành động không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
			}

			try
			{
				// Sử dụng chuỗi kết nối hiện tại từ server, auth, user...
				string serverName = tbServer.Text;
				string databaseName = cbDatabase.Text;
				string authentication = cbAuthen.SelectedItem?.ToString();
				string usernameConn = tbUsername.Text;
				string password = tbPassword.Text;

				string connectionString;
				if (authentication == "SQL Server Authentication")
				{
					connectionString = $"Server={serverName};Database={databaseName};User Id={usernameConn};Password={password};";
				}
				else
				{
					connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
				}

				using (var conn = new SqlConnection(connectionString))
				using (var cmd = new SqlCommand(sql, conn))
				{
					conn.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show($"{action} quyền {permission} cho {username} thành công!",
									"Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi thực thi {action.ToLower()} quyền: {ex.Message}",
								"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool HasPermissionToGrant()
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(currentConnectionString))
				{
					connection.Open();
					string query = "SELECT IS_SRVROLEMEMBER('securityadmin')";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						object result = command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int roleMember))
						{
							return roleMember == 1;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kiểm tra quyền tài khoản: " + ex.Message, "Lỗi",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			Encrypt en = new Encrypt();
			en.Show();
			this.Close();
		}

		// Nút "Thu hồi quyền"
		private void btnRevoke_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(currentConnectionString))
			{
				MessageBox.Show("Vui lòng kết nối trước khi thao tác phân quyền.", "Chưa kết nối",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!HasPermissionToGrant())
			{
				MessageBox.Show("Tài khoản hiện tại không có quyền phân quyền (không thuộc securityadmin).",
								"Không đủ quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (dgvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Chọn user trước khi thu hồi quyền.", "Thông báo",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			ExecutePermission("REVOKE");
		}

		private void btnDeny_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(currentConnectionString))
			{
				MessageBox.Show("Vui lòng kết nối trước khi thao tác phân quyền.", "Chưa kết nối",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!HasPermissionToGrant())
			{
				MessageBox.Show("Tài khoản hiện tại không có quyền phân quyền (không thuộc securityadmin).",
								"Không đủ quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (dgvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Chọn user trước khi từ chối quyền.", "Thông báo",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			ExecutePermission("DENY");
		}

		private void btnRes_Click(object sender, EventArgs e)
		{
			Restore restore = new Restore();
			restore.Show();
			this.Hide();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Backup backup = new Backup();
			backup.Show();
			this.Hide();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			string serverName = tbServer.Text;
			string authentication = cbAuthen.SelectedItem?.ToString();
			string username = tbUsername.Text;
			string password = tbPassword.Text;

			if (string.IsNullOrWhiteSpace(serverName))
			{
				MessageBox.Show("Vui lòng nhập Server Name!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string connectionString;
			if (authentication == "SQL Server Authentication")
			{
				connectionString = $"Server={serverName};Database=master;User Id={username};Password={password};";
			}
			else
			{
				connectionString = $"Server={serverName};Database=master;Integrated Security=True;";
			}

			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					MessageBox.Show("Kết nối thành công!");

					// Lưu thông tin kết nối vào các biến toàn cục nếu cần dùng lại

					// Tải danh sách database
					LoadDatabases(serverName, authentication, username, password);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Không thể kết nối: {ex.Message}");
			}
		}

		private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedDatabase = cbDatabase.SelectedItem?.ToString();
			if (string.IsNullOrEmpty(selectedDatabase)) return;

			string serverName = tbServer.Text;
			string authentication = cbAuthen.SelectedItem?.ToString();
			string username = tbUsername.Text;
			string password = tbPassword.Text;

			string connectionString;
			if (authentication == "SQL Server Authentication")
			{
				connectionString = $"Server={serverName};Database={selectedDatabase};User Id={username};Password={password};";
			}
			else
			{
				connectionString = $"Server={serverName};Database={selectedDatabase};Integrated Security=True;";
			}

			try
			{
				using (var conn = new SqlConnection(connectionString))
				{
					conn.Open();
					string sql = @"
					SELECT
						name      AS UserName,
						type_desc AS UserType
					FROM sys.database_principals
					WHERE type IN ('S','U')
					  AND name NOT LIKE '##%';";

					var da = new SqlDataAdapter(sql, conn);
					var dt = new DataTable();
					da.Fill(dt);
					dgvUsers.DataSource = dt;

					// ✅ Cập nhật connection string dùng chung
					currentConnectionString = connectionString;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải danh sách user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void dgvUsers_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvUsers.SelectedRows.Count > 0)
			{
				string selectedUsername = dgvUsers.SelectedRows[0].Cells["UserName"].Value.ToString();
				txtUsername.Text = selectedUsername;
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{

		}
	}
}
