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
    public partial class LichSuDatHangForm : Form
    {
        LichSuDatHangControl lsdhcon = new LichSuDatHangControl();

        public LichSuDatHangForm()
        {
            InitializeComponent();
            ListView();
            ShowLSDH();
            ShowNCC();
            ShowTrangThai();
        }

        public void ListView()
        {
            lvLSDH.View = View.Details;
            lvLSDH.Columns.Add("Mã Đơn Đặt Hàng", 150);
            lvLSDH.Columns.Add("Mã Nhà Cung Cấp", 150);
            lvLSDH.Columns.Add("Ngày Đặt", 150);
            lvLSDH.Columns.Add("Tổng Tiền", 100);
            lvLSDH.Columns.Add("Trạng Thái", 100);
        }

        public void ShowLSDH()
        {
            DataTable dt = lsdhcon.LichSuDatHang();

            lvLSDH.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["MaDonDatHang"].ToString());

                item.SubItems.Add(dr["MaNhaCC"].ToString());
                item.SubItems.Add(dr["NgayDat"].ToString());
                item.SubItems.Add(dr["TongTien"].ToString());
                item.SubItems.Add(dr["TrangThai"].ToString());
                

                lvLSDH.Items.Add(item);
            }
        }

        public void ShowNCC()
        {
            DataTable dt = lsdhcon.NCC();
            cbbNCC.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                cbbNCC.Items.Add(dr["MaNCC"].ToString());
            }

            cbbNCC.SelectedIndex = -1;
        }

        public void ShowTrangThai()
        {
            cbbTT.Items.Add("Đang xử lý");
            cbbTT.Items.Add("Đã xử lý");

            cbbTT.SelectedIndex = -1;
        }

        private void lvLSDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLSDH.SelectedItems.Count > 0)
            {
                string madh = lvLSDH.SelectedItems[0].Text;

                ChiTietDonHangForm chiTietForm = new ChiTietDonHangForm(madh);
                chiTietForm.ShowDialog();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ncc = cbbNCC.Text;
            string tt = cbbTT.Text;

            DataTable dt = lsdhcon.DonDatHang(ncc,tt);
            if (dt == null)
            {
                MessageBox.Show("Không tìm thấy món!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                lvLSDH.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["MaDonDatHang"].ToString());

                    item.SubItems.Add(dr["MaNhaCC"].ToString());
                    item.SubItems.Add(dr["NgayDat"].ToString());
                    item.SubItems.Add(dr["TongTien"].ToString());
                    item.SubItems.Add(dr["TrangThai"].ToString());


                    lvLSDH.Items.Add(item);
                }
            }
        }

        private void LichSuDatHangForm_Load(object sender, EventArgs e)
        {

        }
    }
}
