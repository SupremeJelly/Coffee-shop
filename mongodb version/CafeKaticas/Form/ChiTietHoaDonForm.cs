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
    public partial class ChiTietHoaDonForm : Form
    {
        LichSuBanHangControl lsbh = new LichSuBanHangControl();
        private string mahd;

        public ChiTietHoaDonForm(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
            ShowDGV();
            ChiTiet();
        }

        public void ShowDGV()
        {
            dgvChiTiet.Columns.Clear();
            dgvChiTiet.Columns.Add("MaHang", "Mã Hang");
            dgvChiTiet.Columns.Add("TenHang", "Tên Hàng");
            dgvChiTiet.Columns.Add("SoLuonng", "Số Lượng");
            dgvChiTiet.Columns.Add("Gia", "Giá");
        }

        public void ChiTiet()
        {
            dgvChiTiet.Rows.Clear();
            List<BsonDocument> chiTietHoaDon = lsbh.ChiTiet(mahd);

            int i = 1;
            foreach (var item in chiTietHoaDon)
            {
                string maMon = item.Contains("MaHang") ? item["MaHang"].ToString() : "";
                string tenMon = item.Contains("TenHang") ? item["TenHang"].ToString() : "";
                string soLuong = item.Contains("SoLuong") ? item["SoLuong"].ToString() : "";
                string gia = item.Contains("Gia") ? item["Gia"].ToString() : "";

                dgvChiTiet.Rows.Add(i, maMon, tenMon, soLuong, gia);
                i++;
            }
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
