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
using Microsoft.Reporting.WinForms;

namespace CafeKaticas
{
    public partial class AdminDashboardForm : UserControl
    {
        DashBoardControl dacon = new DashBoardControl();

        public AdminDashboardForm()
        {
            InitializeComponent();

            displayTongNhanVien();

            displayTongKhachHang();

            displayThuNhapHomNay();

            displayTongThuNhap();

            ThongKe();
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }
            displayTongNhanVien();

            displayTongKhachHang();

            displayThuNhapHomNay();

            displayTongThuNhap();

            ThongKe();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ThongKe()
        {
            int tnv = dacon.TongNhanVien();
            int thd = dacon.TongSoHoaDon();
            float dtn = (float)dacon.DoanhThuNgay();
            float tnhn = (float)dacon.TongDoanhThu();
            string bs = dacon.BestSeller();
            dashboard_tnv.Text = tnv.ToString();
            dashboard_tkh.Text = thd.ToString();
            dashboard_tnhn.Text = dtn.ToString();
            dashboard_ttn.Text = tnhn.ToString();
            dashboard_bs.Text = dacon.BestSeller();

        }

        public BaoCao GetThongKe()
        {
            return new BaoCao
            {
                TNV = int.Parse(dashboard_tnv.Text),
                THD = int.Parse(dashboard_tkh.Text),
                TNHN = float.Parse(dashboard_tnhn.Text.Replace("VND", "").Trim()),
                TTN = float.Parse(dashboard_ttn.Text.Replace("VND", "").Trim()),
                BS = dashboard_bs.Text,
                Date = DateTime.Now
            };
        }


        public void displayTongNhanVien()
        {
            //if (connect.State == ConnectionState.Closed)
            //{
            //    try
            //    {
            //        connect.Open();

            //        string selectData = "SELECT COUNT(*) FROM users WHERE role = @role AND status = @status";

            //        using (SqlCommand cmd = new SqlCommand(selectData, connect))
            //        {
            //            cmd.Parameters.AddWithValue("@role", "Nhân viên");
            //            cmd.Parameters.AddWithValue("@status", "Da kich hoat");

            //            SqlDataReader reader = cmd.ExecuteReader();

            //            if (reader.Read())
            //            {
            //                int count = Convert.ToInt32(reader[0]);
            //                dashboard_tnv.Text = count.ToString();
            //            }

            //            reader.Close();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Kết nối lỗi: " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        connect.Close();
            //    }
            //}
        }

        public void displayTongKhachHang()
        {
            //if (connect.State == ConnectionState.Closed)
            //{
            //    try
            //    {
            //        connect.Open();

            //        string selectData = "SELECT COUNT(id) FROM customers";

            //        using (SqlCommand cmd = new SqlCommand(selectData, connect))
            //        {

            //            SqlDataReader reader = cmd.ExecuteReader();

            //            if (reader.Read())
            //            {
            //                int count = Convert.ToInt32(reader[0]);
            //                dashboard_tkh.Text = count.ToString();
            //            }

            //            reader.Close();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Kết nối lỗi: " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        connect.Close();
            //    }
            //}
        }

        public void displayThuNhapHomNay()
        {
            //if (connect.State == ConnectionState.Closed)
            //{
            //    try
            //    {
            //        connect.Open();

            //        string selectData = "SELECT SUM(total_price) FROM customers WHERE DATE = @date";

            //        using (SqlCommand cmd = new SqlCommand(selectData, connect))
            //        {
            //            DateTime today = DateTime.Today;

            //            string getToday = today.ToString("yyyy-MM-dd");

            //            cmd.Parameters.AddWithValue("@date", getToday);

            //            SqlDataReader reader = cmd.ExecuteReader();

            //            if (reader.Read())
            //            {
            //                //int count = Convert.ToInt32(reader[0]);

            //                float count  = Convert.ToSingle(reader[0]);

            //                dashboard_tnhn.Text = count.ToString("0.00") + "VND";
            //            }

            //            reader.Close();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Kết nối lỗi: " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        connect.Close();
            //    }
            //}
        }
        public void displayTongThuNhap()
        {
            //if (connect.State == ConnectionState.Closed)
            //{
            //    try
            //    {
            //        connect.Open();

            //        string selectData = "SELECT SUM(total_price) FROM customers";

            //        using (SqlCommand cmd = new SqlCommand(selectData, connect))
            //        {

            //            SqlDataReader reader = cmd.ExecuteReader();

            //            if (reader.Read())
            //            {
            //                int count = Convert.ToInt32(reader[0]);
            //                dashboard_ttn.Text = count.ToString("0.00") + "VND";
            //            }

            //            reader.Close();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Kết nối lỗi: " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        connect.Close();
            //    }
            //}
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BCTK_Click(object sender, EventArgs e)
        {
            BaoCao baocao = GetThongKe();

            BaoCaoThongKe bctk = new BaoCaoThongKe();
            bctk.BC(baocao);

            bctk.ShowDialog();
        }
    }
}
