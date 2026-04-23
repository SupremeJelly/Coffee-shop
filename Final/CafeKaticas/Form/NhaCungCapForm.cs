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
    public partial class NhaCungCapForm : UserControl
    {
        NhaCungCapControl ncc = new NhaCungCapControl();

        public NhaCungCapForm()
        {
            InitializeComponent();
            TableDisplay();
            displayNCCData();
            ShowTT();
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            displayNCCData();
        }
        public void TableDisplay()
        {
            dgvNhaCungCap.Columns.Clear();

            dgvNhaCungCap.Columns.Add("STT", "Stt");
            dgvNhaCungCap.Columns.Add("MaNCC", "Mã");
            dgvNhaCungCap.Columns.Add("TenNCC", "Tên");
            dgvNhaCungCap.Columns.Add("DiaChi", "Địa chỉ");
            dgvNhaCungCap.Columns.Add("SDT", "Số điện thoại");
            dgvNhaCungCap.Columns.Add("Email", "Email");
            dgvNhaCungCap.Columns.Add("TrangThai", "Trạng thái");
        }

        public void displayNCCData()
        {
            dgvNhaCungCap.Rows.Clear();
            List<BsonDocument> nccList = ncc.DSNhaCungCap();

            int i = 1;
            foreach (var doc in nccList)
            {
                dgvNhaCungCap.Rows.Add(
                    i++,
                    doc["MaNCC"].AsString,
                    doc["Ten"].AsString,
                    doc["DiaChi"].AsString,
                    doc["SDT"].AsString,
                    doc["Email"].AsString,
                    doc["TrangThai"].AsString
                );
            }
        }

        public void ShowTT()
        {
            cbTrangThai.Items.Add("Đang hợp tác");
            cbTrangThai.Items.Add("Ngừng hợp tác");

            cbTrangThai.SelectedIndex = -1;
        }

        public bool emptyFields()
        {
            if (tbMaNCC.Text == "" || tbTen.Text == "" || tbDiaChi.Text == "" || tbSDT.Text == "" || tbEmail.Text == "" || cbTrangThai.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void addNCC_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string id = tbMaNCC.Text;
                string name = tbTen.Text;
                string address = tbDiaChi.Text;
                string number = tbSDT.Text;
                string email = tbEmail.Text;
                string status = cbTrangThai.Text;

                ncc.AddNCC(id, name, address, number, email, status);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFields();
                displayNCCData();
            }
        }

        public void clearFields()
        {
            tbMaNCC.Text = "";
            tbTen.Text = "";
            tbDiaChi.Text = "";
            tbSDT.Text = "";
            tbEmail.Text = "";
            cbTrangThai.SelectedIndex = -1;
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
            //i = (int)row.Cells[0].Value;
            tbMaNCC.Text = row.Cells[1].Value.ToString();
            tbTen.Text = row.Cells[2].Value.ToString();
            tbDiaChi.Text = row.Cells[3].Value.ToString();
            tbSDT.Text = row.Cells[4].Value.ToString();
            tbEmail.Text = row.Cells[5].Value.ToString();
            cbTrangThai.Text = row.Cells[6].Value.ToString();
        }

        private void updateNCC_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Cần điền tất cả các mục", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật người dùng không: " + tbTen.Text.Trim()
                    + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string id = tbMaNCC.Text;
                    string name = tbTen.Text;
                    string address = tbDiaChi.Text;
                    string number = tbSDT.Text;
                    string email = tbEmail.Text;
                    string status = cbTrangThai.Text;

                    ncc.UpdateNCC(id, name, address, number, email, status);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearFields();
                    displayNCCData();
                }
            }
        }

        private void timkiemNCC_btn_Click(object sender, EventArgs e)
        {
            string timkiem = tbtimkiem.Text;

            if (string.IsNullOrEmpty(timkiem))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn mục cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filteredData = ncc.SearchNCC(timkiem);
            if (filteredData.Count > 0)
            {
                dgvNhaCungCap.Rows.Clear();
                int i = 1;
                foreach (var doc in filteredData)
                {
                    dgvNhaCungCap.Rows.Add(
                        i++,
                        doc["MaNCC"].AsString,
                        doc["Ten"].AsString,
                        doc["DiaChi"].AsString,
                        doc["SDT"].AsString,
                        doc["Email"].AsString,
                        doc["TrangThai"].AsString
                    );
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
