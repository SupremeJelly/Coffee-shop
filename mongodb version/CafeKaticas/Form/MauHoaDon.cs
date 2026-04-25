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
    public partial class MauHoaDon : Form
    {
        public List<HD> hoadon;
        public List<CTHD> cthd;

        public MauHoaDon(List<HD> hoadon, List<CTHD> cthd)
        {
            InitializeComponent();
            this.hoadon = hoadon;
            this.cthd = cthd;
        }

        private void MauHoaDon_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "CafeKaticas.HoaDonReport.rdlc";

            ReportDataSource rds1 = new ReportDataSource("DataSet1", cthd);
            ReportDataSource rds2 = new ReportDataSource("DataSet2", hoadon);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.DataSources.Add(rds2);


            this.reportViewer1.RefreshReport();
        }
    }
}
