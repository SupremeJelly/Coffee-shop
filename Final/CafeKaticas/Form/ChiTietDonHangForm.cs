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
    public partial class ChiTietDonHangForm : Form
    {
        Database db = new Database();
        CTDDHControl ctcon = new CTDDHControl(); 

        private string maddh;

        public ChiTietDonHangForm(string maddh)
        {
            InitializeComponent();
            this.maddh = maddh;
            CTDDH();
            DonHang();
            ShowCTDDH();

        }

        public void CTDDH()
        {
            lvCTDDH.View = View.Details;

            lvCTDDH.Columns.Add("Mã Hàng", 130);
            lvCTDDH.Columns.Add("Tên Hàng", 350);
            lvCTDDH.Columns.Add("Số Lượng", 100);
            lvCTDDH.Columns.Add("Đơn Vị Tính", 100);
            lvCTDDH.Columns.Add("Giá", 100);
        }

        public void DonHang()
        {
            txtDonHang.Text += maddh;
        }

        public void ShowCTDDH()
        {
            List<BsonDocument> documents = ctcon.CTDDH(maddh);
            lvCTDDH.Items.Clear();

            foreach (var doc in documents)
            {
                ListViewItem item = new ListViewItem(doc["MaHang"].AsString);
                item.SubItems.Add(doc["TenHang"].AsString);
                item.SubItems.Add(doc["SoLuong"].ToString());
                item.SubItems.Add(doc["DonViTinh"].AsString);
                item.SubItems.Add(doc["Gia"].ToString());
                lvCTDDH.Items.Add(item);
            }
        }

        private void ChiTietDonHangForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lvCTDDH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
