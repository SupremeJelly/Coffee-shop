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
            var documents = lsdhcon.LichSuDatHang();
            lvLSDH.Items.Clear();

            foreach (var doc in documents)
            {
                ListViewItem item = new ListViewItem(doc["MaDonDatHang"].AsString);
                item.SubItems.Add(doc["MaNhaCC"].AsString);
                item.SubItems.Add(doc["NgayDat"].ToLocalTime().ToString("dd/MM/yyyy"));
                item.SubItems.Add(doc["TongTien"].ToString());
                item.SubItems.Add(doc["TrangThai"].AsString);

                lvLSDH.Items.Add(item);
            }
        }

        public void ShowNCC()
        {
            var suppliers = lsdhcon.NCC();
            cbbNCC.Items.Clear();
            cbbNCC.Items.AddRange(suppliers.ToArray());
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

            var documents = lsdhcon.DonDatHang(ncc, tt);
            if (documents.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đơn hàng!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                lvLSDH.Items.Clear();

                foreach (var doc in documents)
                {
                    ListViewItem item = new ListViewItem(doc["MaDonDatHang"].AsString);
                    item.SubItems.Add(doc["MaNhaCC"].AsString);
                    item.SubItems.Add(doc["NgayDat"].ToLocalTime().ToString("dd/MM/yyyy"));
                    item.SubItems.Add(doc["TongTien"].ToString());
                    item.SubItems.Add(doc["TrangThai"].AsString);

                    lvLSDH.Items.Add(item);
                }
            }
        }
    }
}
