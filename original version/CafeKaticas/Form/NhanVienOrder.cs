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

namespace CafeKaticas
{
    public partial class NhanVienOrder : UserControl
    {
        NhanVienOrderControl acon = new NhanVienOrderControl();

        public static int getCustID;
        public NhanVienOrder()
        {
            InitializeComponent();


            displayAvailableProds();

            displayAllOrders();

            displaytotalPrice();
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

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            displayAvailableProds();

            displayAllOrders();

            displaytotalPrice();
        }

        public void displayAvailableProds()
        {
            NhanVienOrderProdData allProds = new NhanVienOrderProdData();

            List<NhanVienOrderProdData> listData = allProds.availableProductsData();

            NhanVienOrder_menuTable.DataSource = listData;
        }

        public void displayAllOrders()
        {
            NhanVienOrderData allOrders = new NhanVienOrderData();

            List<NhanVienOrderData> listData = allOrders.ordersListData();


            NhanVienOrder_orderTable.DataSource = listData;
        }

        private float totalPrice;
        public void displaytotalPrice()
        {
            try
            {
                NhanVienOrderControl orderControl = new NhanVienOrderControl();

                float totalPrice = orderControl.CalculateTotalPrice();

                NhanVienOrder_orderPrice.Text = totalPrice.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalculateTotalPrice()
        {
            float totalprice = 0;

            foreach(DataGridViewRow dr in NhanVienOrder_orderTable.Rows)
            {
                if (dr.Cells["ThanhTien"].Value != null)
                {
                    totalprice += float.Parse(dr.Cells["ThanhTien"].Value.ToString());
                }
            }

            NhanVienOrder_tong.Text = totalprice.ToString("N0");
        }

        private void NhanVienOrder_tong_TextChanged(object sender, EventArgs e)
        {
            
        }

        public int GenerateOrderID()
        {
            Random rand = new Random();
            return rand.Next(1, 1000000);
        }

        private int rowIndex = 0;

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            displayAvailableProds();
        }

        private void NhanVienOrder_ttBtn_Click_1(object sender, EventArgs e)
        {
            if (NhanVienOrder_tong.Text == "" || NhanVienOrder_orderTable.Rows.Count < 0)
            {
                MessageBox.Show("Sai gì đó rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //IDGenerator();
                int Ma = idGen;
                DateTime today = DateTime.Today;
                float tong = float.Parse(NhanVienOrder_orderPrice.Text.Trim());
                float thua = float.Parse(NhanVienOrder_change.Text.Trim());
                float nhan = float.Parse(NhanVienOrder_tong.Text.Trim());

                acon.TTOrder(tong, today, thua, nhan);
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                foreach (DataGridViewRow row in NhanVienOrder_orderTable.Rows)
                {
                    if (row.Cells["Mã"].Value == null || row.Cells["Lượng"].Value == null)
                    {
                        MessageBox.Show("Dữ liệu hàng bị thiếu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    string itemId = row.Cells["Mã"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["Lượng"].Value);

                    try
                    {
                        acon.UpdateKho(itemId, quantity);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi cập nhật kho cho {itemId}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



                displaytotalPrice();
            }
        }

        private void NhanVienOrder_menuTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string itemId = NhanVienOrder_orderTable.Rows[e.RowIndex].Cells["Mã"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xóa sản phẩm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    acon.DeleteProductFromOrder(itemId);
                }
            }
        }

        private void NhanVienOrder_addBtn_Click_1(object sender, EventArgs e)
        {
            //IDGenerator();

            if (NhanVienOrder_type.SelectedIndex == -1 || NhanVienOrder_Ma.SelectedIndex == -1
                || NhanVienOrder_tensp.Text == "" || NhanVienOrder_sl.Value == 0
                || NhanVienOrder_gia.Text == "")
            {
                MessageBox.Show("Cần chọn sản phẩm trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float getPrice = 0;
                DateTime today = DateTime.Today;

                string ten = NhanVienOrder_tensp.Text.Trim();
                string id = NhanVienOrder_Ma.Text.Trim();
                float totalPrice = getPrice * ((int)NhanVienOrder_sl.Value);
                int sl = Convert.ToInt32(NhanVienOrder_sl.Text.Trim());
                float price = float.Parse(NhanVienOrder_gia.Text.Trim()) * ((int)NhanVienOrder_sl.Value);
                float donprice = float.Parse(NhanVienOrder_gia.Text.Trim());

                string type = NhanVienOrder_type.SelectedItem.ToString();




                acon.AddOrder(ten, id, sl, price, today, type, donprice);

                displaytotalPrice();
                displayAllOrders();
            }
        }

        private int idGen = 0;

        private void NhanVienOrder_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhanVienOrder_Ma.SelectedIndex = -1;
            NhanVienOrder_Ma.Items.Clear();
            NhanVienOrder_tensp.Text = "";
            NhanVienOrder_gia.Text = "";

            string selectedValue = NhanVienOrder_type.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    string query = $"SELECT MaMon FROM Mon WHERE Loai = N'{selectedValue}' AND TrangThai = N'Đang bán'";
                    Database db = new Database();
                    DataTable dt = db.Execute(query);

                    foreach (DataRow row in dt.Rows)
                    {
                        string value = row["MaMon"].ToString();
                        NhanVienOrder_Ma.Items.Add(value);
                    }
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Lỗi: " + exx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NhanVienOrder_Ma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = NhanVienOrder_Ma.SelectedItem as string;
            if (selectedValue != null)
            {
                try
                {
                    NhanVienOrderControl orderControl = new NhanVienOrderControl();

                    string query = $"SELECT * FROM Mon WHERE MaMon = N'{selectedValue}' AND TrangThai = N'Đang bán'";
                    Database db = new Database();
                    DataTable dt = db.Execute(query);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        string prodName = row["TenMon"].ToString();
                        string prodPrice = row["Gia"].ToString();

                        NhanVienOrder_tensp.Text = prodName;
                        NhanVienOrder_gia.Text = prodPrice;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NhanVienOrder_tong_TextChanged_1(object sender, EventArgs e)
        {
            //IDGenerator();
        }

        private void NhanVienOrder_tong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(NhanVienOrder_tong.Text);

                    float getChange = (getAmount - Convert.ToSingle(NhanVienOrder_orderPrice.Text));

                    if (getChange <= -1)
                    {
                        NhanVienOrder_tong.Text = "";
                        NhanVienOrder_change.Text = "";
                    }
                    else
                    {
                        NhanVienOrder_change.Text = getChange.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NhanVienOrder_tong.Text = "";
                    NhanVienOrder_change.Text = "";
                }
            }
        }
        private DataGridView dgvHoaDon;

        private void NhanVienOrder_hdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = @"Data Source=MY-DESKTOP;Initial Catalog=KATICAS;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sqlHoaDon = "SELECT * FROM HoaDon";
                    string sqlChiTietHoaDon = "SELECT * FROM ChiTietHoaDon";

                    SqlDataAdapter daHoaDon = new SqlDataAdapter(sqlHoaDon, conn);
                    SqlDataAdapter daChiTietHoaDon = new SqlDataAdapter(sqlChiTietHoaDon, conn);

                    DataSet ds = new DataSet();
                    daHoaDon.Fill(ds, "HoaDon");
                    daChiTietHoaDon.Fill(ds, "ChiTietHoaDon");

                    HoaDon hoaDon = new HoaDon();
                    hoaDon.HoaDon_Load(ds);
                    hoaDon.ShowDialog();
                    acon.ResetOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private DataTable GetDataFromDatabase()
        {
            string connectionString = @"Data Source=MY-DESKTOP;Initial Catalog=KATICAS;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ChiTietHoaDon";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        private void NhanVienOrder_xoaBtn_Click(object sender, EventArgs e)
        {
            acon.ResetOrder();
        }
    }
}
