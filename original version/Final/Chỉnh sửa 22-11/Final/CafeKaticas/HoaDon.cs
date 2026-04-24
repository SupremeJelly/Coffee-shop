using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CafeKaticas
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private SqlConnection conn;


        private DataSet ReadDataSet(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message, "Thông báo lỗi");
            }
            return ds;
        }

        public void HoaDon_Load(DataSet ds)
        {
            try
            {
                reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                reportViewer1.LocalReport.ReportEmbeddedResource = "CafeKaticas.HoaDon.rdlc";

                reportViewer1.LocalReport.DataSources.Clear();


                if (ds.Tables["HoaDon"].Rows.Count > 0)
                {
                    ReportDataSource rdsHoaDon = new ReportDataSource
                    {
                        Name = "DataSet1",
                        Value = ds.Tables["HoaDon"]
                    };
                    reportViewer1.LocalReport.DataSources.Add(rdsHoaDon);
                }

                if (ds.Tables["ChiTietHoaDon"].Rows.Count > 0)
                {
                    ReportDataSource rdsChiTietHoaDon = new ReportDataSource
                    {
                        Name = "DataSet2",
                        Value = ds.Tables["ChiTietHoaDon"]
                    };
                    reportViewer1.LocalReport.DataSources.Add(rdsChiTietHoaDon);
                }

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}