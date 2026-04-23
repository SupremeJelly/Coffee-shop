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
    public partial class NhapHang : UserControl
    {

        NhapHangControl nhctrl = new NhapHangControl();
        public NhapHang()
        {
            InitializeComponent();
            ShowDgv();
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
        }
        public void ShowDgv()
        {
            dgvNhapHang.Columns.Clear();

            dgvNhapHang.Columns.Add("MaDonDatHang", "Mã đơn");
            dgvNhapHang.Columns.Add("NgayDat", "Ngày đặt");
            dgvNhapHang.Columns.Add("TongTien", "Tổng Tiền");
            dgvNhapHang.Columns.Add("TrangThai", "Trạng thái");

            var documents = nhctrl.NhapHang();
            if (documents.Count == 0)
            {
                MessageBox.Show("Thiếu thông tin!");
            }
            else
            {
                foreach (var doc in documents)
                {
                    dgvNhapHang.Rows.Add(
                        doc["MaDonDatHang"].ToString(),
                        doc["NgayDat"].ToString(),
                        doc["TongTien"].ToString(),
                        doc["TrangThai"].ToString()
                    );
                }
            }
        }

        public void Refresh()
        {
            ShowDgv();
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhapHang.Rows[e.RowIndex];
                string maDonHang = row.Cells["MaDonDatHang"].Value.ToString();

                ChiTietNhapHang ctnh = new ChiTietNhapHang(maDonHang, this);
                ctnh.ShowDialog();
            }
        }

        private void dgvNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime timkiem = dtpTimKiem.Value;
            var documents = nhctrl.TimKiem(timkiem);

            if (documents == null || documents.Count == 0)
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                dgvNhapHang.Rows.Clear();
                foreach (var doc in documents)
                {
                    dgvNhapHang.Rows.Add(
                        doc["MaDonDatHang"].ToString(),
                        doc["NgayDat"].ToString(),
                        doc["TongTien"].ToString(),
                        doc["TrangThai"].ToString()
                    );
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LichSuNhapHang lsnh = new LichSuNhapHang();
            lsnh.Show();
        }
    }
}
