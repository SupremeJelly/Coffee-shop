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
    public partial class ChiTietLSNH : Form
    {
        LSNHControl lscon = new LSNHControl();
        string maddh;

        public ChiTietLSNH(string maddh)
        {
            InitializeComponent();
            
            this.maddh = maddh;
            ShowDGV();
        }

        public void ShowDGV()
        {
            dgvChiTiet.Columns.Clear();
            dgvChiTiet.Columns.Add("MaHang", "Mã hàng");
            dgvChiTiet.Columns.Add("TenHang", "Tên hàng");
            dgvChiTiet.Columns.Add("SoLuong", "Số Lượng");
            dgvChiTiet.Columns.Add("DonViTinh", "Đơn vị tính");
            dgvChiTiet.Columns.Add("Gia", "Giá");
            ChiTiet(maddh);
        }

        public void ChiTiet(string maddh)
        {
            dgvChiTiet.Rows.Clear();
            List<BsonDocument> documents = lscon.ChiTietNhapHang(maddh);
            foreach (var doc in documents)
            {
                dgvChiTiet.Rows.Add(doc.Contains("MaHang").ToString(), doc.Contains("TenHang").ToString(), doc.Contains("SoLuong").ToString(), doc.Contains("DonViTinh").ToString(), doc.Contains("Gia").ToString());
            }

        }

        private void ChiTietLSNH_Load(object sender, EventArgs e)
        {

        }
    }
}
