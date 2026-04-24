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
using System.Diagnostics.Eventing.Reader;

namespace CafeKaticas
{
    public partial class SignIn : Form
    {
        LogInControl logControl = new LogInControl();
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dn_hienmk_CheckedChanged(object sender, EventArgs e)
        {
            dn_mk.PasswordChar = dn_hienmk.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if(dn_nd.Text == "" || dn_mk.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dn_btn_Click(object sender, EventArgs e)
        {
            

            if (emptyFields())
            {
                MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                string username = dn_nd.Text;
                string password = dn_mk.Text;

                if(logControl.LogIn(username, password))
                {
                    string role = logControl.GetRole(username, password);
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (role == "Admin")
                    {
                        AdminMainForm adminForm = new AdminMainForm();
                        adminForm.Show();

                        this.Hide();
                    }
                    else if (role == "Nhân Viên")
                    {
                        CashierMainForm cashierForm = new CashierMainForm();
                        cashierForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên người dụng/mật khẩu không đúng hoặc tài khoản bị khóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
        }
    }
}
