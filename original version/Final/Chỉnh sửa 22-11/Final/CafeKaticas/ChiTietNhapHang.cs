using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKaticas
{
    public partial class ChiTietNhapHang : Form
    {
        ChiTietNhapHangControl ctnh = new ChiTietNhapHangControl();
        NhapHangControl nhcon = new NhapHangControl();
        NhapHang nh;
        private string maDonDatHang;

        public ChiTietNhapHang(string maDonDatHang, NhapHang nh)
        {
            InitializeComponent();
            this.maDonDatHang = maDonDatHang;
            this.nh = nh;
            ShowDgv(maDonDatHang);
        }

        public void ShowDgv(string maDonDatHang)
        {
            dgvSanPhamNhapHang.Columns.Clear();
            dgvSanPhamNhapHang.Columns.Add("MaHang", "Mã hàng");
            dgvSanPhamNhapHang.Columns.Add("TenHang", "Tên Hàng");
            dgvSanPhamNhapHang.Columns.Add("SoLuong", "Số lượng");
            dgvSanPhamNhapHang.Columns.Add("DonViTinh", "Đơn vị tính");
            dgvSanPhamNhapHang.Columns.Add("Gia", "Giá");

            DataTable dt = ctnh.ChiTietNhapHang(maDonDatHang);

            foreach (DataRow row in dt.Rows)
            {
                dgvSanPhamNhapHang.Rows.Add(
                    row["MaHang"].ToString(),
                    row["TenHang"].ToString(),
                    row["SoLuong"].ToString(),
                    row["DonViTinh"].ToString(),
                    row["Gia"].ToString()
                );
            }

            DataTable dtQuyDoi = ctnh.QuyDoi();


            foreach (DataRow row in dt.Rows)
            {
                string donViTinh = row["DonViTinh"].ToString();//Thùng, Hộp, Cái
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                string donViNho = donViTinh;
                int soLuongQuyDoi = soLuong;
                foreach (DataRow rowQuyDoi in dtQuyDoi.Rows)
                {
                    if (rowQuyDoi["DonViLon"].ToString() == donViTinh)
                    {
                        donViNho = rowQuyDoi["DonViNho"].ToString();
                        soLuongQuyDoi = soLuong * Convert.ToInt32(row["SoLuong"]);
                        break;
                    }
                }
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            AddProductControl addProduct = new AddProductControl();

            DataTable dtQuyDoi = ctnh.QuyDoi();

            foreach (DataGridViewRow dgvRow in dgvSanPhamNhapHang.Rows)
            {
                string maHang = dgvRow.Cells["MaHang"].Value.ToString();
                string donViTinh = dgvRow.Cells["DonViTinh"].Value.ToString();
                int soLuong = Convert.ToInt32(dgvRow.Cells["SoLuong"].Value);

                string donViNho = donViTinh;
                int soLuongQuyDoi = soLuong;

                foreach (DataRow rowQuyDoi in dtQuyDoi.Rows)
                {
                    if (rowQuyDoi["DonViLon"].ToString() == donViTinh)
                    {
                        donViNho = rowQuyDoi["DonViNho"].ToString();
                        soLuongQuyDoi = soLuong * Convert.ToInt32(rowQuyDoi["SoLuong"]);
                        break;
                    }
                }
                ctnh.UpdateDonDatHang(maDonDatHang);
                addProduct.UpdateTonkho(maHang, soLuongQuyDoi);
            }

            MessageBox.Show("Đã cập nhật tồn kho!", "Thông báo");

            nh?.RefreshData();
            NhapHangReport report = new NhapHangReport(maDonDatHang);
            report.Show();

            this.Close();
        }
    }
}
