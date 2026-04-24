using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKaticas
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dx_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                SignIn loginForm = new SignIn();
                loginForm.Show();

                this.Hide();
            }
        }

        private void db_btn_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            //adminAddProducts1.Visible = false;
            nhanVienOrder2.Visible = false;
            //nhanVienKhachHang1.Visible = false;

            AdminDashboardForm adForm = adminDashboardForm1 as AdminDashboardForm;

            if (adForm != null)
            {
                adForm.lammoiData();
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            //adminAddProducts1.Visible = false;
            nhanVienOrder2.Visible = true;
            //nhanVienKhachHang1.Visible = false;

            NhanVienOrder noForm = nhanVienOrder2 as NhanVienOrder;

            if (noForm != null)
            {
                noForm.lammoiData();
            }
        }

        private void adminDashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void CashierMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nhanVienOrder2_Load(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}
