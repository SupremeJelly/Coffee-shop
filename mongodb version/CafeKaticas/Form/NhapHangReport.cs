using Microsoft.Reporting.WinForms;
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
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Jelly\OneDrive\Desktop\CSDLNC\Mongo DB\Final\CafeKaticas\NhapHangReport.rdlc";

            nhreport = new NhapHangReportControl();

            List<BsonDocument> documents = nhreport.Report(maddh);

            DataTable dt = ConvertToDataTable(documents);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

        private DataTable ConvertToDataTable(List<BsonDocument> documents)
        {
            DataTable dt = new DataTable();

            if (documents.Count > 0)
            {
                foreach (var key in documents[0].Elements)
                {
                    dt.Columns.Add(key.Name);
                }
                foreach (var document in documents)
                {
                    DataRow row = dt.NewRow();
                    foreach (var key in document.Elements)
                    {
                        row[key.Name] = key.Value.ToString();
                    }
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }

    }
}
