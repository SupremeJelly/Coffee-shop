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
    public partial class AdminMenuForm : UserControl
    {
        MenuControl menucon = new MenuControl();
        

        public AdminMenuForm()
        {
            InitializeComponent();
            ShowDGV();
            ShowCombobox();
            ShowComboboxMon();
            ShowComboboxLoai();
            ShowComboboxTrangThai();
            ShowComboboxNguyenLieu();
            DisplayMenu();
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            DisplayMenu();
        }

        public bool emptyFields()
        {
            if (txtMa.Text == "" || txtMon.Text == ""
                || cbbLoai.SelectedIndex == -1 || cbbDvt.SelectedIndex == -1
                || txtGia.Text == "" || cbbTrangthai.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void clearFields()
        {
            txtMa.Text = "";
            txtMon.Text = "";
            cbbLoai.SelectedIndex = -1;
            cbbDvt.SelectedIndex = -1;
            txtGia.Text = "";
            cbbTrangthai.SelectedIndex = -1;

            txtMa.ReadOnly = false;
        }

        public void DisplayMenu()
        {
            dgvMenu.Rows.Clear();
            DataTable dt = menucon.Menu();
            int i = 1;
            foreach (DataRow dr in dt.Rows)
            {
                dgvMenu.Rows.Add(i, dr["MaMon"], dr["TenMon"], dr["Loai"], dr["Gia"], dr["DonViTinh"],dr["NguyenLieu"], dr["TrangThai"]);
                i++;
            }
        }

        public void ShowCombobox()
        {
            cbbLoai.Items.Add("Thức ăn");
            cbbLoai.Items.Add("Nước uống");

            cbbLoai.SelectedIndex = -1;

            cbbDvt.Items.Add("Chai");
            cbbDvt.Items.Add("Gói");
            cbbDvt.Items.Add("Cái");

            cbbDvt.SelectedIndex = -1;

            cbbTrangthai.Items.Add("Đang bán");
            cbbTrangthai.Items.Add("Ngừng bán");

            cbbTrangthai.SelectedIndex = -1;
        }

        public void ShowComboboxMon()
        {
            DataTable dt = menucon.GetName();
            cbbTimMon.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cbbTimMon.Items.Add(dr["TenMon"].ToString());
            }
            cbbTimMon.SelectedIndex = -1;
        }

        public void ShowComboboxLoai()
        {
            cbbTimLoai.Items.Add("Thức ăn");
            cbbTimLoai.Items.Add("Nước uống");

            cbbTimLoai.SelectedIndex = -1;
        }

        public void ShowComboboxTrangThai()
        {
            cbbTimTT.Items.Add("Đang bán");
            cbbTimTT.Items.Add("Ngừng bán");

            cbbTimTT.SelectedIndex = -1;
        }

        public void ShowComboboxNguyenLieu()
        {
            DataTable dt = menucon.GetNL();
            cbbNguyenLieu.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cbbNguyenLieu.Items.Add(dr["MaHang"].ToString());
            }
            cbbNguyenLieu.SelectedIndex = -1;
        }

        public void ShowDGV()
        {
            dgvMenu.Columns.Clear();

            dgvMenu.Columns.Add("STT", "STT");
            dgvMenu.Columns.Add("MaMon", "Mã Món");
            dgvMenu.Columns.Add("TenMon", "Tên Món");
            dgvMenu.Columns.Add("Loai", "Loại");
            dgvMenu.Columns.Add("Gia", "Giá");
            dgvMenu.Columns.Add("DonViTinh", "Đơn Vị Tính");
            dgvMenu.Columns.Add("NguyenLieu", "Nguyên Liệu");
            dgvMenu.Columns.Add("TrangThai", "Trạng Thái");

        }
        

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                txtMa.Text = row.Cells[1].Value.ToString();
                txtMon.Text = row.Cells[2].Value.ToString();
                cbbLoai.Text = row.Cells[4].Value.ToString();
                txtGia.Text = row.Cells[3].Value.ToString();
                cbbDvt.Text = row.Cells[5].Value.ToString();
                cbbNguyenLieu.Text = row.Cells[6].Value.ToString();
                cbbTrangthai.Text = row.Cells[7].Value.ToString();

                txtMa.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string checkid = txtMa.Text.Trim();
            string checkname = txtMon.Text.Trim();

            if (emptyFields())
            {
                MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (menucon.CheckName(checkname) || menucon.CheckId(checkid))
                {
                    MessageBox.Show("Mã Món: " + txtMa.Text.Trim() + "\nTên món:" + txtMon.Text.Trim() + "đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string id = txtMa.Text.Trim();
                    string name = txtMon.Text.Trim();
                    string type = cbbLoai.Text.Trim();
                    float price = float.Parse(txtGia.Text.Trim());
                    string dvt = cbbDvt.Text.Trim();
                    string nl = cbbNguyenLieu.Text.Trim();
                    string status = cbbTrangthai.Text.Trim();

                    menucon.AddMenu(id, name, type, price, dvt, nl, status);
                    MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearFields();
                    DisplayMenu();
                    ShowComboboxMon();
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            if (emptyFields())
            {
                MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật người dùng không: " + txtMon.Text.Trim()
                    + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string id = txtMa.Text.Trim();
                    string name = txtMon.Text.Trim();
                    string type = cbbLoai.Text.Trim();
                    float price = float.Parse(txtGia.Text.Trim());
                    string dvt = cbbDvt.Text.Trim();
                    string nl = cbbNguyenLieu.Text.Trim();
                    string status = cbbTrangthai.Text.Trim();

                    menucon.UpdateMenu(id, name, type, price, dvt, nl, status);

                    MessageBox.Show("Cập nhật món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearFields();
                    DisplayMenu();
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string timmon = cbbTimMon.Text;
            string timloai = cbbTimLoai.Text;
            string timtt = cbbTimTT.Text;

            if (menucon.Search(timmon, timloai, timtt) == null)
            {
                MessageBox.Show("Không tìm thấy món!","Thông báo",MessageBoxButtons.OK);
            }
            else
            {
                dgvMenu.Rows.Clear();
                DataTable dt = menucon.Search(timmon, timloai, timtt);
                int i = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    dgvMenu.Rows.Add(i, dr["MaMon"], dr["TenMon"], dr["Loai"], dr["Gia"], dr["DonViTinh"], dr["NguyenLieu"], dr["TrangThai"]);
                    i++;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            cbbTimLoai.SelectedIndex = -1;
            cbbTimMon.SelectedIndex = -1;
            cbbTimTT.SelectedIndex = -1;

            DisplayMenu();
        }
    }
}
