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
    public partial class MauDonDatHangForm : Form
    {
        MauDDHControl mauddhcon;

        public string maddh;

        public MauDonDatHangForm(string maddh)
        {
            InitializeComponent();
            this.maddh = maddh;
        }

        private void MauDonDatHangForm_Load(object sender, EventArgs e)
        {
            mauddhcon = new MauDDHControl(maddh);

            DataTable dt1 = mauddhcon.DonDatHang(maddh);
            DataTable dt2 = mauddhcon.ChiTietDonDatHang(maddh);
            DataTable dt3 = mauddhcon.NhaCungCap(maddh);

            ReportDataSource rds1 = new ReportDataSource("DonDatHang",dt1);
            ReportDataSource rds2 = new ReportDataSource("ChiTietDonDatHang", dt2);
            ReportDataSource rds3 = new ReportDataSource("NhaCungCap", dt3);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.DataSources.Add(rds2);
            reportViewer1.LocalReport.DataSources.Add(rds3);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\KYVY\OneDrive\Desktop\Đừng đụng gì nữa nhé\Chỉnh sửa 22-11\Final\CafeKaticas\MauDDH.rdlc";

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
