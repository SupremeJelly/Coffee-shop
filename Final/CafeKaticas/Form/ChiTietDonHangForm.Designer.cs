namespace CafeKaticas
{
    partial class ChiTietDonHangForm
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
            this.lvCTDDH = new System.Windows.Forms.ListView();
            this.txtDonHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvCTDDH
            // 
            this.lvCTDDH.FullRowSelect = true;
            this.lvCTDDH.GridLines = true;
            this.lvCTDDH.HideSelection = false;
            this.lvCTDDH.Location = new System.Drawing.Point(8, 72);
            this.lvCTDDH.Name = "lvCTDDH";
            this.lvCTDDH.Size = new System.Drawing.Size(780, 352);
            this.lvCTDDH.TabIndex = 0;
            this.lvCTDDH.UseCompatibleStateImageBehavior = false;
            this.lvCTDDH.View = System.Windows.Forms.View.Details;
            this.lvCTDDH.SelectedIndexChanged += new System.EventHandler(this.lvCTDDH_SelectedIndexChanged);
            // 
            // txtDonHang
            // 
            this.txtDonHang.AutoSize = true;
            this.txtDonHang.Location = new System.Drawing.Point(12, 26);
            this.txtDonHang.Name = "txtDonHang";
            this.txtDonHang.Size = new System.Drawing.Size(76, 13);
            this.txtDonHang.TabIndex = 1;
            this.txtDonHang.Text = "Đơn đặt hàng:";
            this.txtDonHang.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChiTietDonHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDonHang);
            this.Controls.Add(this.lvCTDDH);
            this.Name = "ChiTietDonHangForm";
            this.Text = "ChiTietDonHangForm";
            this.Load += new System.EventHandler(this.ChiTietDonHangForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCTDDH;
        private System.Windows.Forms.Label txtDonHang;
    }
}