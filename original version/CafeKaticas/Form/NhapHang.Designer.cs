namespace CafeKaticas
{
    partial class NhapHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLichSu = new System.Windows.Forms.Button();
			this.dtpTimKiem = new System.Windows.Forms.DateTimePicker();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvNhapHang = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnLichSu);
			this.panel1.Controls.Add(this.dtpTimKiem);
			this.panel1.Controls.Add(this.btnTimKiem);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.dgvNhapHang);
			this.panel1.Location = new System.Drawing.Point(36, 36);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1595, 822);
			this.panel1.TabIndex = 8;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnLichSu
			// 
			this.btnLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLichSu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLichSu.ForeColor = System.Drawing.Color.White;
			this.btnLichSu.Location = new System.Drawing.Point(31, 71);
			this.btnLichSu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLichSu.Name = "btnLichSu";
			this.btnLichSu.Size = new System.Drawing.Size(248, 48);
			this.btnLichSu.TabIndex = 49;
			this.btnLichSu.Text = "Lịch sử nhập hàng";
			this.btnLichSu.UseVisualStyleBackColor = false;
			this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
			// 
			// dtpTimKiem
			// 
			this.dtpTimKiem.Location = new System.Drawing.Point(1108, 80);
			this.dtpTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpTimKiem.Name = "dtpTimKiem";
			this.dtpTimKiem.Size = new System.Drawing.Size(265, 22);
			this.dtpTimKiem.TabIndex = 48;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimKiem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimKiem.ForeColor = System.Drawing.Color.White;
			this.btnTimKiem.Location = new System.Drawing.Point(1416, 68);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(141, 48);
			this.btnTimKiem.TabIndex = 47;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(1283, 412);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(0, 23);
			this.label10.TabIndex = 40;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 25);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(486, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Danh sách các đơn hàng đang xử lý";
			// 
			// dgvNhapHang
			// 
			this.dgvNhapHang.AllowUserToAddRows = false;
			this.dgvNhapHang.AllowUserToDeleteRows = false;
			this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhapHang.EnableHeadersVisualStyles = false;
			this.dgvNhapHang.Location = new System.Drawing.Point(31, 156);
			this.dgvNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvNhapHang.Name = "dgvNhapHang";
			this.dgvNhapHang.ReadOnly = true;
			this.dgvNhapHang.RowHeadersVisible = false;
			this.dgvNhapHang.RowHeadersWidth = 51;
			this.dgvNhapHang.Size = new System.Drawing.Size(1527, 636);
			this.dgvNhapHang.TabIndex = 3;
			this.dgvNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellClick);
			this.dgvNhapHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellContentClick);
			// 
			// NhapHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "NhapHang";
			this.Size = new System.Drawing.Size(1668, 917);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.DateTimePicker dtpTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLichSu;
    }
}
