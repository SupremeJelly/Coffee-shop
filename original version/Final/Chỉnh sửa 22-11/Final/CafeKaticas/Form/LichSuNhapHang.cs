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
                DataTable dt = lsctrl.LichSuNhapHang();
                dgvLichSuNhapHang.Rows.Clear();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Thiếu thông tin!");
                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvLichSuNhapHang.Rows.Add(
                            row["MaDonDatHang"].ToString(),
                            row["NgayDat"].ToString(),
                            row["TongTien"].ToString(),
                            row["TrangThai"].ToString()
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

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
