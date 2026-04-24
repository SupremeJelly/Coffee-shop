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

            ThongKe();
        }

        public void lammoiData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)lammoiData);
                return;
            }

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
            //string bs = dacon.BestSeller();
            dashboard_tnv.Text = tnv.ToString();
            dashboard_tkh.Text = thd.ToString();
            dashboard_tnhn.Text = dtn.ToString();
            dashboard_ttn.Text = tnhn.ToString();
            //dashboard_bs.Text = dacon.BestSeller();

        }

        public BaoCao GetThongKe()
        {
            return new BaoCao
            {
                TNV = int.Parse(dashboard_tnv.Text),
                THD = int.Parse(dashboard_tkh.Text),
                TNHN = float.Parse(dashboard_tnhn.Text.Replace("VND", "").Trim()),
                TTN = float.Parse(dashboard_ttn.Text.Replace("VND", "").Trim()),
                Date = DateTime.Now
            };
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
