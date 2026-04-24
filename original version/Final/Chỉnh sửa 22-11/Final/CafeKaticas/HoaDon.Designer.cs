namespace CafeKaticas
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KATICASDataSet1 = new CafeKaticas.KATICASDataSet1();
            this.ChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonTableAdapter = new CafeKaticas.KATICASDataSet1TableAdapters.HoaDonTableAdapter();
            this.ChiTietHoaDonTableAdapter = new CafeKaticas.KATICASDataSet1TableAdapters.ChiTietHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KATICASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.KATICASDataSet1;
            // 
            // KATICASDataSet1
            // 
            this.KATICASDataSet1.DataSetName = "KATICASDataSet1";
            this.KATICASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiTietHoaDonBindingSource
            // 
            this.ChiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.ChiTietHoaDonBindingSource.DataSource = this.KATICASDataSet1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ChiTietHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CafeKaticas.HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(913, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietHoaDonTableAdapter
            // 
            this.ChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 642);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KATICASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private KATICASDataSet1 KATICASDataSet1;
        private System.Windows.Forms.BindingSource ChiTietHoaDonBindingSource;
        private KATICASDataSet1TableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
        private KATICASDataSet1TableAdapters.ChiTietHoaDonTableAdapter ChiTietHoaDonTableAdapter;
    }
}