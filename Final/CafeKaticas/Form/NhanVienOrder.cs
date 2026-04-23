using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using MongoDB.Bson;

namespace CafeKaticas
{
    public partial class NhanVienOrder : UserControl
    {

        NhanVienOrderControl acon = new NhanVienOrderControl();

        public static int getCustID;
        public NhanVienOrder()
        {
            InitializeComponent();
            ShowDGV();
            ShowOrderDGV();
            ShowcbbHang();
            displayAvailableProds();
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            displayAvailableProds();
        }

        public void ShowDGV()
        {
            NhanVienOrder_menuTable.Columns.Clear();
            NhanVienOrder_menuTable.Columns.Add("STT", "STT");
            NhanVienOrder_menuTable.Columns.Add("MaHang", "Mã");
            NhanVienOrder_menuTable.Columns.Add("TenHang", "Tên");
            NhanVienOrder_menuTable.Columns.Add("DonViTinh", "Đơn Vị Tính");
            NhanVienOrder_menuTable.Columns.Add("Gia", "Giá");
        }

        public void ShowOrderDGV()
        {
            NhanVienOrder_orderTable.Columns.Clear();
            NhanVienOrder_orderTable.Columns.Add("MaHang", "Mã");
            NhanVienOrder_orderTable.Columns.Add("TenHang", "Tên");
            NhanVienOrder_orderTable.Columns.Add("SoLuong", "Số lượng");
            NhanVienOrder_orderTable.Columns.Add("Gia", "Giá");
            NhanVienOrder_orderTable.Columns.Add("ThanhTien", "Thành Tiền");
        }

        public void displayAvailableProds()
        {
            NhanVienOrder_menuTable.Rows.Clear();
            var products = acon.GetAvailableProducts();
            int i = 1;

            foreach (var product in products)
            {
                NhanVienOrder_menuTable.Rows.Add(
                    i,
                    product["MaHang"],
                    product["TenHang"],
                    product["DonViTinh"],
                    product["Gia"]
                );
                i++;
            }
        }

        public void ShowcbbHang()
        {
            cbbHang.Items.Clear();
            var products = acon.GetAvailableProducts();

            foreach (var product in products)
            {
                string maHang = product["MaHang"].ToString();
                string tenHang = product["TenHang"].ToString();

                cbbHang.Items.Add(new KeyValuePair<string, string>(maHang, tenHang));
            }

            cbbHang.DisplayMember = "Value";
            cbbHang.ValueMember = "Key";

            cbbHang.SelectedIndex = -1;
        }

        public void clearField()
        {
            txtHang.Text = "";
            txtMa.Text = "";
            txtGia.Text = "";
            txtDVT.Text = "";
            numSL.Value = 0;
        }

        public void CalculateTotalPrice()
        {
            float totalprice = 0;

            foreach (DataGridViewRow dr in NhanVienOrder_orderTable.Rows)
            {
                if (dr.Cells["ThanhTien"].Value != null)
                {
                    totalprice += float.Parse(dr.Cells["ThanhTien"].Value.ToString());
                }
            }

            NhanVienOrder_tong.Text = totalprice.ToString("N0");
        }

        //public string IDGenerator()
        //{
        //    string lastid = acon.NewestOrder();

        //    if (string.IsNullOrEmpty(lastid) || lastid.Length < 2)
        //    {
        //        return "HD001";
        //    }

        //    int lastNumber;
        //    if (!int.TryParse(lastid.Substring(2), out lastNumber))
        //    {
        //        throw new Exception("Lỗi: Không thể parse số từ mã hóa đơn!");
        //    }

        //    int newNumber = lastNumber + 1;
        //    return $"HD{newNumber:D3}";
        //}

        private void NhanVienOrder_menuTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = NhanVienOrder_menuTable.Rows[e.RowIndex];
                txtMa.Text = row.Cells[1].Value.ToString();
                txtHang.Text = row.Cells[2].Value.ToString();
                txtDVT.Text = row.Cells[3].Value.ToString();
                txtGia.Text = row.Cells[4].Value.ToString();

                NhanVienOrder_menuTable.Tag = e.RowIndex;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbbHang.SelectedIndex >= 0)
            {
                var selectedItem = (KeyValuePair<string, string>)cbbHang.SelectedItem;
                string mahang = selectedItem.Key;

                var products = acon.SearchProduct(mahang);

                NhanVienOrder_menuTable.Rows.Clear();
                int i = 1;
                foreach (var product in products)
                {
                    NhanVienOrder_menuTable.Rows.Add(
                        i,
                        product["MaHang"],
                        product["TenHang"],
                        product["DonViTinh"],
                        product["Gia"]
                    );
                    i++;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            displayAvailableProds();
        }

        private void NhanVienOrder_addBtn_Click(object sender, EventArgs e)
        {
            if (numSL.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mahang = txtMa.Text.Trim();
            string tenhang = txtHang.Text.Trim();
            int sl = (int)numSL.Value;
            float gia = float.Parse(txtGia.Text.Trim());
            float thanhtien = sl * gia;

            foreach (DataGridViewRow row in NhanVienOrder_orderTable.Rows)
            {
                if (row.Cells["MaHang"].Value != null && row.Cells["MaHang"].Value.ToString() == mahang)
                {
                    MessageBox.Show("Sản phẩm này đã có trong hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (DataGridViewRow row in NhanVienOrder_orderTable.Rows)
            {
                if (row.Cells["MaHang"].Value.ToString() == mahang)
                {
                    int currentQty = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["SoLuong"].Value = currentQty + sl;
                    row.Cells["ThanhTien"].Value = (currentQty + sl) * gia;

                    CalculateTotalPrice();
                    return;
                }
            }

            NhanVienOrder_orderTable.Rows.Add(mahang, tenhang, sl, gia, thanhtien);

            CalculateTotalPrice();
            clearField();
        }

        private void NhanVienOrder_resetBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy đơn hàng?","Thông báo",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                NhanVienOrder_orderTable.Rows.Clear();
                MessageBox.Show("Đã hủy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NhanVienOrder_orderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = NhanVienOrder_orderTable.Rows[e.RowIndex];
                string productName = selectedRow.Cells["TenHang"].Value.ToString();

                DialogResult result = MessageBox.Show($"Xóa sản phẩm '{productName}' khỏi hóa đơn?","Xác nhận xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    NhanVienOrder_orderTable.Rows.RemoveAt(e.RowIndex);
                    CalculateTotalPrice();

                    MessageBox.Show($"Sản phẩm '{productName}' đã được xóa khỏi hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void NhanVienOrder_ttBtn_Click(object sender, EventArgs e)
        {
            if (NhanVienOrder_tong.Text == "" || NhanVienOrder_orderTable.Rows.Count <= 0)
            {
                MessageBox.Show("Sai gì đó rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow dr in NhanVienOrder_orderTable.Rows)
            {
                string itemId = dr.Cells["MaHang"].Value.ToString();
                int quantity = Convert.ToInt32(dr.Cells["SoLuong"].Value);

                if (!acon.CheckStock(itemId, quantity))
                {
                    MessageBox.Show($"Sản phẩm {dr.Cells["TenHang"].Value} không đủ số lượng trong kho!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string Ma = acon.GenerateMaHoaDon();
            DateTime today = DateTime.Today;
            float tong = float.Parse(NhanVienOrder_tong.Text.Trim());

            acon.TTOrder(Ma, tong, today);

            List<HD> hd = new List<HD> {
                new HD { MaHoaDon = Ma, TongTien = tong, Ngay = today }
            };

            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<CTHD> cthd = new List<CTHD>();

            foreach (DataGridViewRow dr in NhanVienOrder_orderTable.Rows)
            {
                string itemId = dr.Cells["MaHang"].Value.ToString();
                string ten = dr.Cells["TenHang"].Value.ToString();
                int quantity = Convert.ToInt32(dr.Cells["SoLuong"].Value);
                float gia = float.Parse(dr.Cells["Gia"].Value.ToString());

                cthd.Add(new CTHD
                {
                    MaHoaDon = Ma,
                    MaHang = itemId,
                    TenHang = ten,
                    SoLuong = quantity,
                    Gia = gia,
                    Ngay = today,
                });

                acon.CTOrder(Ma, itemId, ten, quantity, gia * quantity, today);

                acon.UpdateStock(itemId, quantity);
            }

            CalculateTotalPrice();

            MauHoaDon hoadon = new MauHoaDon(hd, cthd);
            hoadon.ShowDialog();

            NhanVienOrder_orderTable.Rows.Clear();
            clearField();
        }
    }
}
