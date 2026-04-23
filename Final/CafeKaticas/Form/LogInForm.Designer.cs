namespace CafeKaticas
{
    partial class SignIn
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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dn_nd = new System.Windows.Forms.TextBox();
            this.dn_mk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dn_hienmk = new System.Windows.Forms.CheckBox();
            this.dn_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 484);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hệ thống quản lý ATV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeKaticas.Properties.Resources.logo_ca_phe_nong;
            this.pictureBox1.Location = new System.Drawing.Point(103, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(656, 9);
            this.close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(18, 18);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đăng nhập:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dn_nd
            // 
            this.dn_nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_nd.Location = new System.Drawing.Point(349, 153);
            this.dn_nd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dn_nd.Name = "dn_nd";
            this.dn_nd.Size = new System.Drawing.Size(296, 26);
            this.dn_nd.TabIndex = 4;
            // 
            // dn_mk
            // 
            this.dn_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_mk.Location = new System.Drawing.Point(349, 225);
            this.dn_mk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dn_mk.Name = "dn_mk";
            this.dn_mk.PasswordChar = '*';
            this.dn_mk.Size = new System.Drawing.Size(296, 26);
            this.dn_mk.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu:";
            // 
            // dn_hienmk
            // 
            this.dn_hienmk.AutoSize = true;
            this.dn_hienmk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_hienmk.Location = new System.Drawing.Point(349, 266);
            this.dn_hienmk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dn_hienmk.Name = "dn_hienmk";
            this.dn_hienmk.Size = new System.Drawing.Size(127, 17);
            this.dn_hienmk.TabIndex = 7;
            this.dn_hienmk.Text = "Hiển thị mật khẩu";
            this.dn_hienmk.UseVisualStyleBackColor = true;
            this.dn_hienmk.CheckedChanged += new System.EventHandler(this.dn_hienmk_CheckedChanged);
            // 
            // dn_btn
            // 
            this.dn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dn_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_btn.ForeColor = System.Drawing.Color.White;
            this.dn_btn.Location = new System.Drawing.Point(349, 321);
            this.dn_btn.Name = "dn_btn";
            this.dn_btn.Size = new System.Drawing.Size(111, 34);
            this.dn_btn.TabIndex = 8;
            this.dn_btn.Text = "Đăng nhập";
            this.dn_btn.UseVisualStyleBackColor = false;
            this.dn_btn.Click += new System.EventHandler(this.dn_btn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 484);
            this.Controls.Add(this.dn_btn);
            this.Controls.Add(this.dn_hienmk);
            this.Controls.Add(this.dn_mk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dn_nd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dn_nd;
        private System.Windows.Forms.TextBox dn_mk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox dn_hienmk;
        private System.Windows.Forms.Button dn_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

