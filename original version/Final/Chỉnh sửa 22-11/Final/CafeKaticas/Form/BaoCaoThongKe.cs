using Microsoft.Reporting.WinForms;
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
    public partial class BaoCaoThongKe : Form
    {
        AdminDashboardForm adminDashboardForm;

        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        public void BC(BaoCao baoCao)
        {
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Phu\Downloads\Chỉnh sửa 22-11-20241213T173757Z-001\Chỉnh sửa 22-11\Final\CafeKaticas\BCTK.rdlc";

            var bc = new List<BaoCao> { baoCao };

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bc));

            reportViewer1.RefreshReport();
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
