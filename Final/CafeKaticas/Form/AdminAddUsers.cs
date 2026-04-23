using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using MongoDB.Bson;

namespace CafeKaticas
{

    public partial class AdminAddUsers : UserControl
    {
        AddUserControl acon = new AddUserControl();

        public AdminAddUsers()
        {
            InitializeComponent();

            TableDisplay();

            displayUserData();
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            displayUserData();
        }

        public void TableDisplay()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("STT", "STT");
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("TaiKhoan", "Tài Khoản");
            dataGridView1.Columns.Add("MatKhau", "Mật Khẩu");
            dataGridView1.Columns.Add("HoTen", "Họ Tên");
            dataGridView1.Columns.Add("ChucVu", "Chức Vụ");
            dataGridView1.Columns.Add("TrangThai", "Trạng Thái");
            dataGridView1.Columns.Add("NgayVaoLam", "Ngày Vào Làm");
        }

        public void displayUserData()
        {
            dataGridView1.Rows.Clear();

            List<BsonDocument> users = acon.GetAllUsers();
            int i = 1;
            foreach (var user in users)
            {
                dataGridView1.Rows.Add(
                    i,
                    user["id"].AsString,
                    user["TaiKhoan"].AsString,
                    user["MatKhau"].AsString,
                    user["HoTen"].AsString,
                    user["ChucVu"].AsString,
                    user["TrangThai"].AsString,
                    user["NgayVaoLam"].ToUniversalTime().ToString("yyyy-MM-dd")
                );
                i++;
            }
        }

        public bool emptyFields()
        {
            if(adminAddUsers_username.Text == "" || adminAddUsers_password.Text == "" || adminAddUsers_name.Text == ""
                || adminAddUsers_role.Text == "" || adminAddUsers_status.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (!acon.CheckUserName(adminAddUsers_username.Text) && !acon.CheckID(adminAddUsers_id.Text))
            {
                if (emptyFields())
                {
                    MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    acon.AddUser(
                        adminAddUsers_id.Text,
                        adminAddUsers_username.Text,
                        adminAddUsers_password.Text,
                        adminAddUsers_name.Text,
                        adminAddUsers_role.Text,
                        adminAddUsers_status.Text,
                        DateTime.Today
                    );
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    displayUserData();
                }
            }
            else
            {
                if (acon.CheckUserName(adminAddUsers_username.Text))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (acon.CheckID(adminAddUsers_id.Text))
                {
                    MessageBox.Show("ID đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tên tài khoản và ID đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int i = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            i = (int)row.Cells[0].Value;
            adminAddUsers_id.Text = row.Cells[1].Value.ToString();
            adminAddUsers_username.Text = row.Cells[2].Value.ToString();
            adminAddUsers_password.Text = row.Cells[3].Value.ToString();
            adminAddUsers_name.Text = row.Cells[4].Value.ToString();
            adminAddUsers_role.Text = row.Cells[5].Value.ToString();
            adminAddUsers_status.Text = row.Cells[6].Value.ToString();

            adminAddUsers_id.ReadOnly = true;

        }

        private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                acon.UpdateUser(
                    adminAddUsers_id.Text,
                    adminAddUsers_username.Text,
                    adminAddUsers_password.Text,
                    adminAddUsers_name.Text,
                    adminAddUsers_role.Text,
                    adminAddUsers_status.Text,
                    DateTime.Today
                );
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
                displayUserData();
            }
        }

        public void clearFields()
        {
            adminAddUsers_id.Text = "";
            adminAddUsers_username.Text = "";
            adminAddUsers_password.Text = "";
            adminAddUsers_role.SelectedIndex = -1;
            adminAddUsers_status.SelectedIndex = -1;

            adminAddUsers_id.ReadOnly = false;

        }

        private void dminAddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dminAddUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Cần chọn tại khoản để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa người dùng không: " + adminAddUsers_username.Text.Trim()
                    + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string id = adminAddUsers_id.Text;
                    acon.DeleteUser(id);
                    displayUserData();
                }
            }
        }
    }
}
