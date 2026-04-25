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
    public partial class LichSuBanHang : UserControl
    {
        LichSuBanHangControl lsbh = new LichSuBanHangControl();
        public string maddh;

        public LichSuBanHang()
        {
            InitializeComponent();
            ShowDGV();

            displayKhachHangData();
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            displayKhachHangData();
        }

        public void ShowDGV()
        {
            dgvHoaDon.Columns.Clear();
            dgvHoaDon.Columns.Add("STT", "STT");
            dgvHoaDon.Columns.Add("MaHoaDon", "Mã Hóa Đơn");
            dgvHoaDon.Columns.Add("TongTien", "Tổng tiền");
            dgvHoaDon.Columns.Add("Ngày", "Ngày");
        }

        public void displayKhachHangData()
        {
            dgvHoaDon.Rows.Clear();

            List<BsonDocument> documents = lsbh.LichSu();
            int i = 1;

            foreach (var doc in documents)
            {
                dgvHoaDon.Rows.Add(
                    i,
                    doc.GetValue("MaHoaDon", "").AsString,
                    doc.GetValue("TongTien", "").ToString(),
                    doc.GetValue("Ngay", "").ToString()
                );
                i++;
            }
        }

        private void datagridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvHoaDon.Rows.Count)
                return;

            string mahd = dgvHoaDon.Rows[e.RowIndex].Cells["MaHoaDon"].Value?.ToString();

            if (string.IsNullOrEmpty(mahd))
            {
                MessageBox.Show("Không thể lấy thông tin hóa đơn. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChiTietHoaDonForm chiTietForm = new ChiTietHoaDonForm(mahd);
            chiTietForm.ShowDialog();
        }
    }
}
