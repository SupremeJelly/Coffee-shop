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
    public partial class NhapHangReport : Form
    {
        NhapHangReportControl nhreport;
        public string maddh;

        public NhapHangReport(string maddh)
        {
            InitializeComponent();
            this.maddh = maddh;
        }

        private void NhapHangReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = @"C:\Users\KYVY\OneDrive\Desktop\Đừng đụng gì nữa nhé\Chỉnh sửa 22-11\Final\CafeKaticas\NhapHangReport.rdlc";

            nhreport = new NhapHangReportControl(maddh);

            DataTable dt = nhreport.Report(maddh);
            ReportDataSource rds = new ReportDataSource("ChiTietDonDatHang",dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}
