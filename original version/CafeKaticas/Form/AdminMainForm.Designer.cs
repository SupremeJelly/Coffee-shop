namespace CafeKaticas
{
    partial class AdminMainForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnLichSu = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.dx_btn = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lichSuBanHang1 = new CafeKaticas.LichSuBanHang();
			this.adminAddUsers1 = new CafeKaticas.AdminAddUsers();
			this.adminAddProducts1 = new CafeKaticas.AdminAddProducts();
			this.nhapHang1 = new CafeKaticas.NhapHang();
			this.adminAddUsers2 = new CafeKaticas.AdminAddUsers();
			this.adminDatHang1 = new CafeKaticas.AdminDatHang();
			this.nhaCungCapForm1 = new CafeKaticas.NhaCungCapForm();
			this.adminMenuForm1 = new CafeKaticas.AdminMenuForm();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.close);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1924, 55);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Hệ thống quản lý Katicas";
			// 
			// close
			// 
			this.close.AutoSize = true;
			this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.close.Location = new System.Drawing.Point(1961, 11);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(22, 23);
			this.close.TabIndex = 2;
			this.close.Text = "X";
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.btnLichSu);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.btnMenu);
			this.panel2.Controls.Add(this.dx_btn);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 55);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(320, 868);
			this.panel2.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CafeKaticas.Properties.Resources.logo_ca_phe_nong;
			this.pictureBox1.Location = new System.Drawing.Point(90, 46);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(133, 123);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// btnLichSu
			// 
			this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLichSu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLichSu.ForeColor = System.Drawing.Color.White;
			this.btnLichSu.Location = new System.Drawing.Point(20, 729);
			this.btnLichSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLichSu.Name = "btnLichSu";
			this.btnLichSu.Size = new System.Drawing.Size(276, 39);
			this.btnLichSu.TabIndex = 26;
			this.btnLichSu.Text = "Lịch sử bán hàng";
			this.btnLichSu.UseVisualStyleBackColor = false;
			this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(19, 670);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(276, 39);
			this.button4.TabIndex = 25;
			this.button4.Text = "Nhập hàng";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(20, 609);
			this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(276, 39);
			this.button6.TabIndex = 24;
			this.button6.Text = "Đặt hàng";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click_1);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(20, 548);
			this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(276, 39);
			this.button5.TabIndex = 23;
			this.button5.Text = "Quản lý nhà cung cấp";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// btnMenu
			// 
			this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenu.ForeColor = System.Drawing.Color.White;
			this.btnMenu.Location = new System.Drawing.Point(20, 489);
			this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(276, 39);
			this.btnMenu.TabIndex = 22;
			this.btnMenu.Text = "Menu";
			this.btnMenu.UseVisualStyleBackColor = false;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// dx_btn
			// 
			this.dx_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dx_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dx_btn.ForeColor = System.Drawing.Color.White;
			this.dx_btn.Location = new System.Drawing.Point(19, 802);
			this.dx_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dx_btn.Name = "dx_btn";
			this.dx_btn.Size = new System.Drawing.Size(276, 39);
			this.dx_btn.TabIndex = 21;
			this.dx_btn.Text = "Đăng xuất";
			this.dx_btn.UseVisualStyleBackColor = false;
			this.dx_btn.Click += new System.EventHandler(this.button6_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(20, 428);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(276, 39);
			this.button3.TabIndex = 18;
			this.button3.Text = "Quản lý tồn kho";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(20, 366);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(276, 39);
			this.button2.TabIndex = 17;
			this.button2.Text = "Quản lý nhân viên";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(20, 305);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(276, 39);
			this.button1.TabIndex = 16;
			this.button1.Text = "Dasboard";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(141, 266);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Admin";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(15, 266);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Username: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(43, 209);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 29);
			this.label2.TabIndex = 13;
			this.label2.Text = "Quản lý Katicas";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.nhapHang1);
			this.panel3.Controls.Add(this.adminAddUsers2);
			this.panel3.Controls.Add(this.adminDatHang1);
			this.panel3.Controls.Add(this.nhaCungCapForm1);
			this.panel3.Controls.Add(this.adminMenuForm1);
			this.panel3.Controls.Add(this.lichSuBanHang1);
			this.panel3.Controls.Add(this.adminAddUsers1);
			this.panel3.Controls.Add(this.adminAddProducts1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(320, 55);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1604, 868);
			this.panel3.TabIndex = 2;
			// 
			// lichSuBanHang1
			// 
			this.lichSuBanHang1.Location = new System.Drawing.Point(-1, 0);
			this.lichSuBanHang1.Margin = new System.Windows.Forms.Padding(5);
			this.lichSuBanHang1.Name = "lichSuBanHang1";
			this.lichSuBanHang1.Size = new System.Drawing.Size(1667, 917);
			this.lichSuBanHang1.TabIndex = 9;
			this.lichSuBanHang1.Visible = false;
			// 
			// adminAddUsers1
			// 
			this.adminAddUsers1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminAddUsers1.Location = new System.Drawing.Point(-3, 0);
			this.adminAddUsers1.Margin = new System.Windows.Forms.Padding(5);
			this.adminAddUsers1.Name = "adminAddUsers1";
			this.adminAddUsers1.Size = new System.Drawing.Size(1668, 917);
			this.adminAddUsers1.TabIndex = 2;
			// 
			// adminAddProducts1
			// 
			this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
			this.adminAddProducts1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.adminAddProducts1.Name = "adminAddProducts1";
			this.adminAddProducts1.Size = new System.Drawing.Size(1668, 917);
			this.adminAddProducts1.TabIndex = 1;
			// 
			// nhapHang1
			// 
			this.nhapHang1.Location = new System.Drawing.Point(0, 0);
			this.nhapHang1.Margin = new System.Windows.Forms.Padding(5);
			this.nhapHang1.Name = "nhapHang1";
			this.nhapHang1.Size = new System.Drawing.Size(1668, 917);
			this.nhapHang1.TabIndex = 8;
			this.nhapHang1.Visible = false;
			// 
			// adminAddUsers2
			// 
			this.adminAddUsers2.Location = new System.Drawing.Point(0, 0);
			this.adminAddUsers2.Margin = new System.Windows.Forms.Padding(5);
			this.adminAddUsers2.Name = "adminAddUsers2";
			this.adminAddUsers2.Size = new System.Drawing.Size(1668, 917);
			this.adminAddUsers2.TabIndex = 7;
			this.adminAddUsers2.Visible = false;
			// 
			// adminDatHang1
			// 
			this.adminDatHang1.Location = new System.Drawing.Point(0, 0);
			this.adminDatHang1.Margin = new System.Windows.Forms.Padding(5);
			this.adminDatHang1.Name = "adminDatHang1";
			this.adminDatHang1.Size = new System.Drawing.Size(1668, 917);
			this.adminDatHang1.TabIndex = 6;
			this.adminDatHang1.Visible = false;
			// 
			// nhaCungCapForm1
			// 
			this.nhaCungCapForm1.Location = new System.Drawing.Point(0, 0);
			this.nhaCungCapForm1.Margin = new System.Windows.Forms.Padding(5);
			this.nhaCungCapForm1.Name = "nhaCungCapForm1";
			this.nhaCungCapForm1.Size = new System.Drawing.Size(1651, 870);
			this.nhaCungCapForm1.TabIndex = 5;
			this.nhaCungCapForm1.Visible = false;
			// 
			// adminMenuForm1
			// 
			this.adminMenuForm1.Location = new System.Drawing.Point(0, 0);
			this.adminMenuForm1.Margin = new System.Windows.Forms.Padding(5);
			this.adminMenuForm1.Name = "adminMenuForm1";
			this.adminMenuForm1.Size = new System.Drawing.Size(1668, 917);
			this.adminMenuForm1.TabIndex = 4;
			this.adminMenuForm1.Visible = false;
			// 
			// AdminMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 923);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AdminMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminMainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMainForm_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button dx_btn;
        private AdminDashboardForm adminDashboardForm1;
        private AdminAddUsers adminAddUsers1;
        private AdminAddProducts adminAddProducts1;
        private System.Windows.Forms.Button btnMenu;
        private AdminMenuForm adminMenuForm1;
        private System.Windows.Forms.Button button5;
        private NhaCungCapForm nhaCungCapForm1;
        private System.Windows.Forms.Button button6;
        private AdminDatHang adminDatHang1;
        private AdminAddUsers adminAddUsers2;
        private System.Windows.Forms.Button button4;
        private NhapHang nhapHang1;
        private System.Windows.Forms.Button btnLichSu;
        private LichSuBanHang lichSuBanHang1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}