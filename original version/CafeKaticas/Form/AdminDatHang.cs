using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CafeKaticas
{
    public partial class AdminDatHang : UserControl
    {
        DatHangControl dhcon = new DatHangControl();

        public AdminDatHang()
        {
            InitializeComponent();

            ShowNCC();
            ShowDVT();
            ShowDgv();
            ShowHang();
        }
        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            ShowNCC();
        }

        public void ShowNCC()
        {
            DataTable dt = dhcon.NhaCungCap();
            cbbNCC.DataSource = dt;
            cbbNCC.DisplayMember = "Ten";
            cbbNCC.ValueMember = "MaNCC";

            cbbNCC.SelectedIndex = -1;
        }

        public void ShowDVT()
        {
            cbbDonViTinh.Items.Add("Thùng");
            cbbDonViTinh.Items.Add("Hộp");
            cbbDonViTinh.Items.Add("Cái");

            cbbDonViTinh.SelectedIndex = -1;
        }

        public void ShowHang()
        {
            DataTable dt = dhcon.HangHoa();
            cbbHang.DataSource = dt;

            cbbHang.DisplayMember = "TenHang";
            cbbHang.ValueMember = "MaHang";

            cbbHang.SelectedIndex = -1;
        }

        public void ShowDgv()
        {
            dgvDatHang.Columns.Clear();

            dgvDatHang.Columns.Add("STT", "Stt");
            dgvDatHang.Columns.Add("MaHang","Mã hàng");
            dgvDatHang.Columns.Add("TenHang", "Tên hàng");
            dgvDatHang.Columns.Add("SoLuong", "Số lượng");
            dgvDatHang.Columns.Add("DonViTinh", "DVT");
            dgvDatHang.Columns.Add("Gia", "Giá");

        }

        public bool emptyFields()
        {
            if (cbbNCC.SelectedIndex == -1 || txtMaNCC.Text == "" || txtMa.Text == ""
                || cbbHang.SelectedIndex == -1 || txtMaHang.Text == "" || cbbDonViTinh.SelectedIndex == -1
                || numSl.Text == "" || txtGia.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool emptyDonDatHang()
        {
            if (cbbNCC.SelectedIndex == -1 || txtMaNCC.Text == "" || txtMa.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool emptyDgv()
        {
            if (dgvDatHang.Rows.Count == 0) { return true; }
            return false;
        }

        private void ClearForm()
        {
            txtMaNCC.Text = "";
            cbbNCC.SelectedIndex = -1;
            cbbHang.SelectedIndex = -1;
            txtMa.Text = "";
            txtMaHang.Text = "";
            cbbDonViTinh.SelectedIndex = -1;
            txtGia.Text = "";
            numSl.Value = 0;

            dgvDatHang.Rows.Clear();
            txtTong.Clear();
        }

        private void clearSP()
        {
            txtMaHang.Clear();
            cbbHang.SelectedIndex = -1;
            txtGia.Clear();
            numSl.Value = 0;
            cbbDonViTinh.SelectedIndex = -1;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            //string mancc = cbbMaNCC.Text;
            //string maddh = txtMa.Text;
            //DateTime ngaydat = DateTime.Now;
            //float tongtien = float.Parse(txtTong.Text.Trim());
            int i = dgvDatHang.Rows.Count + 1;

            if (emptyFields())
            {
                MessageBox.Show("Cần nhập đủ thông tin!");
            }

            

            else
            {
                string ten = cbbHang.Text;
                string ma = txtMaHang.Text;
                string dvt = cbbDonViTinh.Text;

                int sl = (int)numSl.Value;
                float gia = float.Parse(txtGia.Text);

                foreach (DataGridViewRow dr in dgvDatHang.Rows)
                {
                    if (dr.Cells["MaHang"].Value != null && dr.Cells["MaHang"].Value.ToString() == ma)
                    {
                        MessageBox.Show($"Sản phẩm :'{ma}' đã có!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    i++;
                }

                dgvDatHang.Rows.Add(i,ma, ten, sl, dvt, gia);

                UpdateTongTien();
                
            }

            clearSP();
        }

        private void UpdateTongTien()
        {
            decimal tongtien = 0;
            foreach (DataGridViewRow row in dgvDatHang.Rows)
            {
                string giatien = row.Cells["Gia"].Value.ToString();
                string soluong = row.Cells["Soluong"].Value.ToString();
                decimal gia;
                decimal sl;

                if (decimal.TryParse(giatien, out gia) && decimal.TryParse(soluong, out sl))
                {
                    tongtien += gia * sl;
                }
                else
                {
                    MessageBox.Show($"Giá trị không hợp lệ( Giá: {giatien}, Số lượng: {soluong}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            txtTong.Text = tongtien.ToString();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (emptyDonDatHang() || emptyDgv())
            {
                MessageBox.Show("Chưa có đủ thông tin đơn hàng hoặc thông tin hàng đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn đặt hàng?", "Thông báo", MessageBoxButtons.OKCancel);

                if(result == DialogResult.OK)
                {
                    string mancc = txtMaNCC.Text;
                    string maddh = txtMa.Text;
                    DateTime ngaydat = DateTime.Now;
                    float tongtien = float.Parse(txtTong.Text.Trim());

                    dhcon.AddDonDatHang(maddh, mancc, ngaydat, tongtien);

                    foreach (DataGridViewRow row in dgvDatHang.Rows)
                    {
                        string mahang = row.Cells["MaHang"].Value.ToString();
                        string tenhang = row.Cells["Tenhang"].Value.ToString();
                        int soluong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                        string dvt = row.Cells["DonViTinh"].Value.ToString();
                        float gia = float.Parse(row.Cells["Gia"].Value.ToString());

                        dhcon.AddChiTietDonDatHang(maddh, mahang, tenhang, dvt, soluong, gia);

                    }

                    MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    //MauDonDatHangForm mau = new MauDonDatHangForm(maddh);
                    //mau.Show();

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Đặt hàng đã bị hủy!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNCC.SelectedIndex >= 0)
            {
                txtMaNCC.Text = cbbNCC.SelectedValue.ToString();
            }

            else
            {
                txtMaNCC.Clear();
            }
        }

        private void dgvDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDatHang.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells[1].Value.ToString();
                cbbHang.Text = row.Cells[2].Value.ToString();
                cbbDonViTinh.Text = row.Cells[3].Value.ToString();
                numSl.Text = row.Cells[4].Value.ToString();
                txtGia.Text = row.Cells[5].Value.ToString();

                dgvDatHang.Tag = e.RowIndex;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDatHang.Tag == null)
            {
                MessageBox.Show("Chọn sản phẩm cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = (int)dgvDatHang.Tag;

            if (emptyFields())
            {
                MessageBox.Show("Cần nhập đủ thông tin!");
            }
            else
            {
                string ma = txtMaHang.Text;
                string ten = cbbHang.Text;
                string dvt = cbbDonViTinh.Text;
                int sl = (int)numSl.Value;
                float gia = float.Parse(txtGia.Text);

                DataGridViewRow row = dgvDatHang.Rows[i];
                row.Cells["MaHang"].Value = ma;
                row.Cells["TenHang"].Value = ten;
                row.Cells["SoLuong"].Value = sl;
                row.Cells["DonViTinh"].Value = dvt;
                row.Cells["Gia"].Value = gia;

                UpdateTongTien();
                dgvDatHang.Tag = null;

                MessageBox.Show("Cập nhật thàng công!","Thông báo",MessageBoxButtons.OK);

                clearSP();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDatHang.Tag == null)
            {
                MessageBox.Show("Chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int i = (int)dgvDatHang.Tag;

            dgvDatHang.Rows.RemoveAt(i);

            for (int j = 0; j < dgvDatHang.Rows.Count; j++)
            {
                dgvDatHang.Rows[j].Cells["STT"].Value = j + 1;
            }

            UpdateTongTien();

            dgvDatHang.Tag = null;

            clearSP();

            MessageBox.Show("Đã xóa sản phẩm!","Thông báo",MessageBoxButtons.OK);
        }



        private void cbbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbHang.SelectedValue != null)
            {
                string mahang = cbbHang.SelectedValue.ToString();
                DataRow row = dhcon.Hang(mahang);

                if(row != null)
                {
                    txtMaHang.Text = row["MaHang"].ToString();
                    txtGia.Text = row["Gia"].ToString();
                }
            }
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            LichSuDatHangForm lsdh = new LichSuDatHangForm();
            lsdh.Show();
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
