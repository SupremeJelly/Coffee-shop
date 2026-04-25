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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tắt không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { 
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            { 
                SignIn loginForm  = new SignIn();
                loginForm.Show();

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adminDashboardForm1.Visible = true;
            //adminAddUsers1.Visible = false;
            //adminAddProducts1.Visible = false;
            //adminMenuForm1.Visible = false;
            //nhaCungCapForm1.Visible = false;
            //adminDatHang1.Visible = false;
            //nhapHang1.Visible = false;
            //lichSuBanHang1.Visible = false;

            //AdminDashboardForm adForm = adminDashboardForm1 as AdminDashboardForm;

            //if(adForm != null)
            //{
            //    adForm.lammoiData();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = true;
            adminAddProducts1.Visible = false;
            adminMenuForm1.Visible = false;
            nhaCungCapForm1.Visible = false;
            adminDatHang1.Visible = false;
            nhapHang1.Visible = false;
            lichSuBanHang1.Visible = false;

            AdminAddUsers aaUsers = adminAddUsers1 as AdminAddUsers;
            if (aaUsers != null)
            {
                aaUsers.lammoiData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = true;
            adminMenuForm1.Visible = false;
            nhaCungCapForm1.Visible = false;
            adminDatHang1.Visible = false;
            nhapHang1.Visible = false;
            lichSuBanHang1.Visible = false;

            AdminAddProducts aaProd = adminAddProducts1 as AdminAddProducts;
            if (aaProd != null)
            {
                aaProd.lammoiData();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            adminMenuForm1.Visible = true;
            nhaCungCapForm1.Visible = false;
            adminDatHang1.Visible = false;
            nhapHang1.Visible = false;
            lichSuBanHang1.Visible = false;

            AdminMenuForm adMenu = new AdminMenuForm();
            if (adMenu != null)
            {
                adMenu.lammoiData();
            }
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            adminMenuForm1.Visible = false;
            nhaCungCapForm1.Visible = true;
            adminDatHang1.Visible = false;
            nhapHang1.Visible = false;
            lichSuBanHang1.Visible = false;

            NhaCungCapForm adncc = new NhaCungCapForm();
            if (adncc != null)
            {
                adncc.lammoiData();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            adminMenuForm1.Visible = false;
            nhaCungCapForm1.Visible = false;
            adminDatHang1.Visible = true;
            nhapHang1.Visible = false;
            lichSuBanHang1.Visible = false;

            AdminDatHang addh = new AdminDatHang();
            if (addh != null)
            {
                addh.lammoiData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            adminMenuForm1.Visible = false;
            nhaCungCapForm1.Visible = false;
            adminDatHang1.Visible = false;
            nhapHang1.Visible = true;
            lichSuBanHang1.Visible = false;

            NhapHang nhap = new NhapHang();
            if (nhap != null)
            {
                nhap.lammoiData();
            }
        }

        private void adminDashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            //adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            adminMenuForm1.Visible = false;
            nhaCungCapForm1.Visible = false;
            adminDatHang1.Visible = false;
            nhapHang1.Visible = false;
            lichSuBanHang1.Visible = true ;

            LichSuBanHang lichsu = new LichSuBanHang();
            if(lichsu != null)
            {
                lichsu.lammoiData();
            }
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
