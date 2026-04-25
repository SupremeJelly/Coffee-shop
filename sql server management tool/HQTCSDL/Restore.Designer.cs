namespace HQTCSDL
{
	partial class Restore
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
			this.btnBackUpPannel = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSec = new System.Windows.Forms.Button();
			this.btnRes = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panelRestore = new System.Windows.Forms.Panel();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnFilePath = new System.Windows.Forms.Button();
			this.tbFilePath = new System.Windows.Forms.TextBox();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.lbUsername = new System.Windows.Forms.Label();
			this.cbAuthen = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cbDatabase = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbFileGroup = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.btnEn = new System.Windows.Forms.Button();
			this.panelRestore.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBackUpPannel
			// 
			this.btnBackUpPannel.BackColor = System.Drawing.Color.SpringGreen;
			this.btnBackUpPannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackUpPannel.Location = new System.Drawing.Point(461, 481);
			this.btnBackUpPannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBackUpPannel.Name = "btnBackUpPannel";
			this.btnBackUpPannel.Size = new System.Drawing.Size(241, 46);
			this.btnBackUpPannel.TabIndex = 48;
			this.btnBackUpPannel.Text = "Restore";
			this.btnBackUpPannel.UseVisualStyleBackColor = false;
			this.btnBackUpPannel.Click += new System.EventHandler(this.btnBackUpPannel_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(91, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 20);
			this.label5.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 29);
			this.label8.TabIndex = 0;
			this.label8.Text = "Destination";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "Source";
			// 
			// btnSec
			// 
			this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSec.Location = new System.Drawing.Point(595, 52);
			this.btnSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSec.Name = "btnSec";
			this.btnSec.Size = new System.Drawing.Size(252, 46);
			this.btnSec.TabIndex = 56;
			this.btnSec.Text = "Security";
			this.btnSec.UseVisualStyleBackColor = true;
			this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
			// 
			// btnRes
			// 
			this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRes.Location = new System.Drawing.Point(320, 52);
			this.btnRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRes.Name = "btnRes";
			this.btnRes.Size = new System.Drawing.Size(247, 46);
			this.btnRes.TabIndex = 55;
			this.btnRes.Text = "Restore";
			this.btnRes.UseVisualStyleBackColor = true;
			this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(44, 52);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(249, 46);
			this.btnBack.TabIndex = 54;
			this.btnBack.Text = "Back Up";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(91, -52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(667, 44);
			this.label1.TabIndex = 52;
			this.label1.Text = "Ứng dụng sao lưu và khôi phục dữ liệu";
			// 
			// panelRestore
			// 
			this.panelRestore.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelRestore.Controls.Add(this.btnConnect);
			this.panelRestore.Controls.Add(this.btnFilePath);
			this.panelRestore.Controls.Add(this.tbFilePath);
			this.panelRestore.Controls.Add(this.tbUsername);
			this.panelRestore.Controls.Add(this.tbPassword);
			this.panelRestore.Controls.Add(this.label15);
			this.panelRestore.Controls.Add(this.lbPassword);
			this.panelRestore.Controls.Add(this.lbUsername);
			this.panelRestore.Controls.Add(this.cbAuthen);
			this.panelRestore.Controls.Add(this.label16);
			this.panelRestore.Controls.Add(this.tbServer);
			this.panelRestore.Controls.Add(this.label10);
			this.panelRestore.Controls.Add(this.label5);
			this.panelRestore.Controls.Add(this.label3);
			this.panelRestore.Location = new System.Drawing.Point(21, 122);
			this.panelRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelRestore.Name = "panelRestore";
			this.panelRestore.Size = new System.Drawing.Size(545, 342);
			this.panelRestore.TabIndex = 51;
			this.panelRestore.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRestore_Paint);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(419, 7);
			this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(97, 30);
			this.btnConnect.TabIndex = 59;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnFilePath
			// 
			this.btnFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFilePath.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFilePath.Location = new System.Drawing.Point(472, 244);
			this.btnFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnFilePath.Name = "btnFilePath";
			this.btnFilePath.Size = new System.Drawing.Size(44, 34);
			this.btnFilePath.TabIndex = 62;
			this.btnFilePath.Text = "...";
			this.btnFilePath.UseVisualStyleBackColor = true;
			this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
			// 
			// tbFilePath
			// 
			this.tbFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFilePath.Location = new System.Drawing.Point(171, 246);
			this.tbFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbFilePath.Name = "tbFilePath";
			this.tbFilePath.Size = new System.Drawing.Size(295, 30);
			this.tbFilePath.TabIndex = 63;
			this.tbFilePath.TextChanged += new System.EventHandler(this.tbFilePath_TextChanged);
			// 
			// tbUsername
			// 
			this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsername.Location = new System.Drawing.Point(277, 153);
			this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(239, 30);
			this.tbUsername.TabIndex = 56;
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.Location = new System.Drawing.Point(277, 196);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(239, 30);
			this.tbPassword.TabIndex = 57;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(37, 249);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(128, 25);
			this.label15.TabIndex = 61;
			this.label15.Text = "Restore from:";
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPassword.Location = new System.Drawing.Point(133, 196);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(104, 25);
			this.lbPassword.TabIndex = 54;
			this.lbPassword.Text = "Password:";
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.Location = new System.Drawing.Point(131, 155);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(108, 25);
			this.lbUsername.TabIndex = 55;
			this.lbUsername.Text = "Username:";
			// 
			// cbAuthen
			// 
			this.cbAuthen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAuthen.FormattingEnabled = true;
			this.cbAuthen.Location = new System.Drawing.Point(204, 98);
			this.cbAuthen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbAuthen.Name = "cbAuthen";
			this.cbAuthen.Size = new System.Drawing.Size(312, 33);
			this.cbAuthen.TabIndex = 53;
			this.cbAuthen.SelectedIndexChanged += new System.EventHandler(this.cbAuthen_SelectedIndexChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(36, 102);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(142, 25);
			this.label16.TabIndex = 52;
			this.label16.Text = "Authentication:";
			// 
			// tbServer
			// 
			this.tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbServer.Location = new System.Drawing.Point(204, 46);
			this.tbServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(312, 30);
			this.tbServer.TabIndex = 51;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(48, 46);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(130, 25);
			this.label10.TabIndex = 50;
			this.label10.Text = "Server name:";
			// 
			// cbDatabase
			// 
			this.cbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDatabase.FormattingEnabled = true;
			this.cbDatabase.Location = new System.Drawing.Point(209, 43);
			this.cbDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDatabase.Name = "cbDatabase";
			this.cbDatabase.Size = new System.Drawing.Size(315, 33);
			this.cbDatabase.TabIndex = 64;
			this.cbDatabase.SelectedIndexChanged += new System.EventHandler(this.cbDatabase_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(88, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 25);
			this.label7.TabIndex = 52;
			this.label7.Text = "Database:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(319, -1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(508, 38);
			this.label6.TabIndex = 57;
			this.label6.Text = "Backup and Restore application\r\n";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.cbDatabase);
			this.panel1.Controls.Add(this.cbFileGroup);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.tbPath);
			this.panel1.Controls.Add(this.btnSelectFile);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbType);
			this.panel1.Location = new System.Drawing.Point(587, 122);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(557, 342);
			this.panel1.TabIndex = 58;
			// 
			// cbFileGroup
			// 
			this.cbFileGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFileGroup.FormattingEnabled = true;
			this.cbFileGroup.Location = new System.Drawing.Point(209, 146);
			this.cbFileGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbFileGroup.Name = "cbFileGroup";
			this.cbFileGroup.Size = new System.Drawing.Size(315, 33);
			this.cbFileGroup.TabIndex = 70;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(107, -155);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(546, 44);
			this.label13.TabIndex = 60;
			this.label13.Text = "Backup and Restore application";
			// 
			// tbPath
			// 
			this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPath.Location = new System.Drawing.Point(23, 399);
			this.tbPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(375, 34);
			this.tbPath.TabIndex = 59;
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSelectFile.Location = new System.Drawing.Point(427, 399);
			this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(44, 34);
			this.btnSelectFile.TabIndex = 58;
			this.btnSelectFile.Text = "...";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(-95, 399);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 29);
			this.label9.TabIndex = 57;
			this.label9.Text = "File path:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(93, 139);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(0, 20);
			this.label14.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(77, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 25);
			this.label4.TabIndex = 50;
			this.label4.Text = "File groups:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(55, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 25);
			this.label2.TabIndex = 50;
			this.label2.Text = "Restore Type:";
			// 
			// cbType
			// 
			this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbType.FormattingEnabled = true;
			this.cbType.Location = new System.Drawing.Point(209, 94);
			this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(315, 33);
			this.cbType.TabIndex = 53;
			this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
			// 
			// btnEn
			// 
			this.btnEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEn.Location = new System.Drawing.Point(892, 52);
			this.btnEn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEn.Name = "btnEn";
			this.btnEn.Size = new System.Drawing.Size(252, 46);
			this.btnEn.TabIndex = 59;
			this.btnEn.Text = "Encrypt";
			this.btnEn.UseVisualStyleBackColor = true;
			this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
			// 
			// Restore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1181, 574);
			this.Controls.Add(this.btnEn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnSec);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRes);
			this.Controls.Add(this.panelRestore);
			this.Controls.Add(this.btnBackUpPannel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Restore";
			this.Text = "Restore";
			this.Load += new System.EventHandler(this.Restore_Load);
			this.panelRestore.ResumeLayout(false);
			this.panelRestore.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBackUpPannel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSec;
		private System.Windows.Forms.Button btnRes;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelRestore;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbAuthen;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox tbFilePath;
		private System.Windows.Forms.Button btnFilePath;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.ComboBox cbFileGroup;
        private System.Windows.Forms.Button btnEn;
	}
}