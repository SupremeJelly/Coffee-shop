using MongoDB.Bson;
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
    public partial class ChiTietNhapHang : Form
    {
        ChiTietNhapHangControl ctnh = new ChiTietNhapHangControl();
        public string maddh;
        private NhapHang nhControl;

        public ChiTietNhapHang(string maddh, NhapHang nhControl)
        {
            InitializeComponent();
            this.maddh = maddh;
            ShowDgv(maddh);
            this.nhControl = nhControl;
        }

        public void ShowDgv(string maDonDatHang)
        {
            dgvSanPhamNhapHang.Columns.Clear();
            dgvSanPhamNhapHang.Columns.Add("MaHang", "Mã hàng");
            dgvSanPhamNhapHang.Columns.Add("TenHang", "Tên Hàng");
            dgvSanPhamNhapHang.Columns.Add("SoLuong", "Số lượng");
            dgvSanPhamNhapHang.Columns.Add("DonViTinh", "Đơn vị tính");
            dgvSanPhamNhapHang.Columns.Add("Gia", "Giá");

            try
            {
                List<BsonDocument> documents = ctnh.ChiTietNhapHang(maDonDatHang);

                foreach (var doc in documents)
                {
                    dgvSanPhamNhapHang.Rows.Add(
                        doc.Contains("MaHang") ? doc["MaHang"].ToString() : "",
                        doc.Contains("TenHang") ? doc["TenHang"].ToString() : "",
                        doc.Contains("SoLuong") ? doc["SoLuong"].ToString() : "",
                        doc.Contains("DonViTinh") ? doc["DonViTinh"].ToString() : "",
                        doc.Contains("Gia") ? doc["Gia"].ToString() : ""
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            AddProductControl addProduct = new AddProductControl();

            try
            {
                foreach (DataGridViewRow dgvRow in dgvSanPhamNhapHang.Rows)
                {
                    if (dgvRow.IsNewRow) continue;

                    string maHang = dgvRow.Cells["MaHang"].Value.ToString();
                    int soLuong = Convert.ToInt32(dgvRow.Cells["SoLuong"].Value);

                    addProduct.UpdateTonkho(maHang, soLuong);
                }

                MessageBox.Show("Đã cập nhật tồn kho!", "Thông báo");

                string maDonDatHang = maddh;
                ctnh.CapNhatTrangThaiDonDatHang(maddh);
                NhapHangReport reportForm = new NhapHangReport(maDonDatHang);
                nhControl.Refresh();
                reportForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật tồn kho: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
