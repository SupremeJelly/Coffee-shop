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
            DataTable dt = ctcon.CTDDH(maddh);
            lvCTDDH.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["MaHang"].ToString());
                item.SubItems.Add(dr["TenHang"].ToString());
                item.SubItems.Add(dr["SoLuong"].ToString());
                item.SubItems.Add(dr["DonViTinh"].ToString());
                item.SubItems.Add(dr["Gia"].ToString());
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
