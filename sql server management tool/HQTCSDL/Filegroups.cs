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
	public partial class Filegroups : Form
	{
		private string connectionString;
		private string databaseName;
		public List<string> SelectedFileGroups { get; private set; } = new List<string>();
		public Filegroups(string connStr, string dbName)
		{
			InitializeComponent();
			connectionString = connStr;
			databaseName = dbName;
		}

		private void Filegroups_Load(object sender, EventArgs e)
		{
			LoadFileGroups();
		}
		private void LoadFileGroups()
		{
			// Thiết lập TreeView:
			treeViewFileGroups.CheckBoxes = true;
			treeViewFileGroups.Nodes.Clear();

			// Tạo node gốc là tên database
			TreeNode rootNode = new TreeNode(databaseName);

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					// Truy vấn danh sách filegroups
					string query = "SELECT name FROM sys.filegroups";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								string fgName = reader["name"].ToString();
								// Tạo node cho từng filegroup; nếu cần, bạn có thể bổ sung thêm cây con (vd: các file lưu trong filegroup)
								TreeNode fgNode = new TreeNode(fgName);
								rootNode.Nodes.Add(fgNode);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải filegroups: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			treeViewFileGroups.Nodes.Add(rootNode);
			treeViewFileGroups.ExpandAll();
		}

		private void SetCheckedAllNodes(TreeNodeCollection nodes, bool isChecked)
		{
			foreach (TreeNode node in nodes)
			{
				node.Checked = isChecked;
				if (node.Nodes.Count > 0)
					SetCheckedAllNodes(node.Nodes, isChecked);
			}
		}

		private void btnSelectAll_Click(object sender, EventArgs e)
		{
			SetCheckedAllNodes(treeViewFileGroups.Nodes, true);
		}

		private void btbClearAll_Click(object sender, EventArgs e)
		{
			SetCheckedAllNodes(treeViewFileGroups.Nodes, false);
		}

		private void CollectCheckedNodes(TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{
				if (node.Checked && node.Level > 0)
					SelectedFileGroups.Add(node.Text);
				if (node.Nodes.Count > 0)
					CollectCheckedNodes(node.Nodes);
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			SelectedFileGroups.Clear();
			CollectCheckedNodes(treeViewFileGroups.Nodes);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
