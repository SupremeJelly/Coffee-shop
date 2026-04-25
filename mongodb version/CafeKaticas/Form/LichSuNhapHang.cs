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
    public partial class LichSuNhapHang : Form
    {

        LichSuNhapHangControl lsctrl = new LichSuNhapHangControl();

        public LichSuNhapHang()
        {
            InitializeComponent();
            ShowDgv();
        }

        public void ShowDgv()
        {
            if (dgvLichSuNhapHang.Columns.Count == 0)
            {
                dgvLichSuNhapHang.Columns.Add("MaDonDatHang", "Mã đơn");
                dgvLichSuNhapHang.Columns.Add("NgayDat", "Ngày đặt");
                dgvLichSuNhapHang.Columns.Add("TongTien", "Tổng Tiền");
                dgvLichSuNhapHang.Columns.Add("TrangThai", "Trạng thái");
            }

            try
            {
                List<BsonDocument> documents = lsctrl.LichSuNhapHang();
                dgvLichSuNhapHang.Rows.Clear();

                if (documents.Count == 0)
                {
                    MessageBox.Show("Thiếu thông tin!");
                }
                else
                {
                    foreach (var doc in documents)
                    {
                        dgvLichSuNhapHang.Rows.Add(
                            doc.Contains("MaDonDatHang") ? doc["MaDonDatHang"].ToString() : "",
                            doc.Contains("NgayDat") ? doc["NgayDat"].ToString() : "",
                            doc.Contains("TongTien") ? doc["TongTien"].ToString() : "",
                            doc.Contains("TrangThai") ? doc["TrangThai"].ToString() : ""
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLichSuNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLichSuNhapHang.Rows[e.RowIndex];
                string maddh = row.Cells["MaDonDatHang"].Value.ToString();
                ChiTietLSNH ct = new ChiTietLSNH(maddh);
                ct.Show();
            }
        }
    }
}
