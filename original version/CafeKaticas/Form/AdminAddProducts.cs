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
using System.Diagnostics;
using System.IO;
using System.CodeDom;

namespace CafeKaticas
{
    public partial class AdminAddProducts : UserControl
    {
        AddProductControl acon = new AddProductControl();

        public AdminAddProducts()
        {
            InitializeComponent();
            Notification();
            ShowDgv();
            displayData();
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            displayData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public bool emptyFields()
        {
            if (adminAddProducts_id.Text == "" || adminAddProducts_name.Text == ""
                || adminAddProducts_stock.Text == "" || adminAddProducts_dvt.SelectedIndex == -1
                || adminAddProducts_price.Text == "" || adminAddProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Notification()
        {
            List<string> outofstock = acon.OutOfStock();

            if (outofstock.Count > 0)
            {
                string products = string.Join(", ", outofstock);

                MessageBox.Show("Các hàng đã hết: " + products);
            }
        }

        public void ShowDgv()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("STT","STT");
            dataGridView1.Columns.Add("Mã Hàng", "MaHangHoa");
            dataGridView1.Columns.Add("Tên Hàng", "TenHang");
            dataGridView1.Columns.Add("Số Lượng", "SoLuong");
            dataGridView1.Columns.Add("Đơn Vị Tính", "DonViTinh");
            dataGridView1.Columns.Add("Giá", "Gia");
            dataGridView1.Columns.Add("Trạng Thái", "TrangThai");
        }

        public void DVT()
        {
            adminAddProducts_dvt.Items.Add("Chai");
            adminAddProducts_dvt.Items.Add("Gói");
            adminAddProducts_dvt.Items.Add("Cái");

            adminAddProducts_dvt.SelectedIndex = -1;
        }

        public void Statue()
        {
            adminAddProducts_status.Items.Add("Còn đặt hàng");
            adminAddProducts_status.Items.Add("Ngừng đặt hàng");

            adminAddProducts_status.SelectedIndex = -1;
        }

        public void displayData()
        {
            dataGridView1.Rows.Clear();

            DataTable dt = acon.BangTonKho();
            int i = 1;
            foreach (DataRow dr in dt.Rows) 
            {
                dataGridView1.Rows.Add(i, dr["MaHang"], dr["TenHang"], dr["SoLuong"], dr["DonViTinh"], dr["Gia"], dr["TrangThai"]);
                i++;
            }
        }

        private void adminAddProducts_addBtn_Click(object sender, EventArgs e)
        {
            string checkid = adminAddProducts_id.Text;
            if (emptyFields())
            {
                MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (acon.CheckID(checkid))
                {
                    MessageBox.Show("ID Sản phẩm: " + adminAddProducts_id.Text.Trim() + "đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string id = adminAddProducts_id.Text.Trim();
                    string name = adminAddProducts_name.Text.Trim();
                    int stock = Convert.ToInt32(adminAddProducts_stock.Text.Trim());
                    string dvt = adminAddProducts_dvt.Text.Trim();
                    float price = float.Parse(adminAddProducts_price.Text.Trim());
                    string status = adminAddProducts_status.Text.Trim();

                    acon.AddProduct(id, name, stock, dvt, price, status);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearFields();
                    displayData();
                }
            }
        }

        public void clearFields()
        {
            adminAddProducts_id.Text = "";
            adminAddProducts_name.Text = "";
            adminAddProducts_stock.Text = "";
            adminAddProducts_dvt.Text = "";
            adminAddProducts_price.Text = "";
            adminAddProducts_status.SelectedIndex = -1;

            adminAddProducts_id.ReadOnly = false;
        }

        private void adminAddProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                adminAddProducts_id.Text = row.Cells[1].Value.ToString();
                adminAddProducts_name.Text = row.Cells[2].Value.ToString();
                adminAddProducts_stock.Text = row.Cells[3].Value.ToString();
                adminAddProducts_dvt.Text = row.Cells[4].Value.ToString();
                adminAddProducts_price.Text = row.Cells[5].Value.ToString();
                adminAddProducts_status.Text = row.Cells[6].Value.ToString();
                adminAddProducts_id.ReadOnly = true;
            }
        }

        private void adminAddProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn cập nhật hàng: " + adminAddProducts_id.Text.Trim() + "?"
                    , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(check == DialogResult.Yes)
                {
                    string id = adminAddProducts_id.Text.Trim();
                    string name = adminAddProducts_name.Text.Trim();
                    int stock = Convert.ToInt32(adminAddProducts_stock.Text.Trim());
                    string dvt = adminAddProducts_dvt.Text.Trim();
                    float price = float.Parse(adminAddProducts_price.Text.Trim());
                    string status = adminAddProducts_status.Text.Trim();

                    acon.UpdateProduct(id, name, stock, dvt, price, status);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearFields();
                    displayData();
                }
            }
        }

        private void adminAddProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng: " + adminAddProducts_id.Text.Trim() + "?"
                    , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    string id = adminAddProducts_id.Text.Trim();
                    string name = adminAddProducts_name.Text.Trim();
                    int stock = Convert.ToInt32(adminAddProducts_stock.Text.Trim());
                    float price = float.Parse(adminAddProducts_price.Text.Trim());
                    string status = adminAddProducts_status.Text.Trim();

                    acon.DeleteProduct(id);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearFields();
                    displayData();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}