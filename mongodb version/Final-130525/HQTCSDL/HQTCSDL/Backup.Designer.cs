namespace HQTCSDL
{
	partial class Backup
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
            this.panelBackup = new System.Windows.Forms.Panel();
            this.tbFileG = new System.Windows.Forms.TextBox();
            this.lbFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnBackUpPannel = new System.Windows.Forms.Button();
            this.cbBackupCpnt = new System.Windows.Forms.ComboBox();
            this.cbAuthen = new System.Windows.Forms.ComboBox();
            this.cbBackupType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFileG = new System.Windows.Forms.Label();
            this.lbFilepath = new System.Windows.Forms.Label();
            this.lbBackUpcpnt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.panelBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackup
            // 
            this.panelBackup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBackup.Controls.Add(this.tbFileG);
            this.panelBackup.Controls.Add(this.lbFileName);
            this.panelBackup.Controls.Add(this.tbFileName);
            this.panelBackup.Controls.Add(this.cbDatabase);
            this.panelBackup.Controls.Add(this.btnConnect);
            this.panelBackup.Controls.Add(this.tbUsername);
            this.panelBackup.Controls.Add(this.tbServer);
            this.panelBackup.Controls.Add(this.label13);
            this.panelBackup.Controls.Add(this.tbPassword);
            this.panelBackup.Controls.Add(this.tbPath);
            this.panelBackup.Controls.Add(this.btnSelectFile);
            this.panelBackup.Controls.Add(this.btnBackUpPannel);
            this.panelBackup.Controls.Add(this.cbBackupCpnt);
            this.panelBackup.Controls.Add(this.cbAuthen);
            this.panelBackup.Controls.Add(this.cbBackupType);
            this.panelBackup.Controls.Add(this.label5);
            this.panelBackup.Controls.Add(this.lbFileG);
            this.panelBackup.Controls.Add(this.lbFilepath);
            this.panelBackup.Controls.Add(this.lbBackUpcpnt);
            this.panelBackup.Controls.Add(this.label6);
            this.panelBackup.Controls.Add(this.lbPassword);
            this.panelBackup.Controls.Add(this.lbUsername);
            this.panelBackup.Controls.Add(this.label7);
            this.panelBackup.Controls.Add(this.label10);
            this.panelBackup.Controls.Add(this.label4);
            this.panelBackup.Controls.Add(this.label8);
            this.panelBackup.Controls.Add(this.label3);
            this.panelBackup.Location = new System.Drawing.Point(22, 99);
            this.panelBackup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBackup.Name = "panelBackup";
            this.panelBackup.Size = new System.Drawing.Size(686, 575);
            this.panelBackup.TabIndex = 2;
            // 
            // tbFileG
            // 
            this.tbFileG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileG.Location = new System.Drawing.Point(264, 370);
            this.tbFileG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFileG.Name = "tbFileG";
            this.tbFileG.Size = new System.Drawing.Size(285, 28);
            this.tbFileG.TabIndex = 55;
            this.tbFileG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(126, 484);
            this.lbFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(84, 20);
            this.lbFileName.TabIndex = 53;
            this.lbFileName.Text = "File Name:";
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileName.Location = new System.Drawing.Point(265, 482);
            this.tbFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(284, 26);
            this.tbFileName.TabIndex = 52;
            this.tbFileName.TextChanged += new System.EventHandler(this.tbFileName_TextChanged);
            // 
            // cbDatabase
            // 
            this.cbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(265, 194);
            this.cbDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(285, 28);
            this.cbDatabase.TabIndex = 51;
            this.cbDatabase.SelectedIndexChanged += new System.EventHandler(this.cbDatabase_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(578, 35);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(73, 24);
            this.btnConnect.TabIndex = 50;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(302, 111);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(248, 26);
            this.tbUsername.TabIndex = 49;
            // 
            // tbServer
            // 
            this.tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServer.Location = new System.Drawing.Point(265, 34);
            this.tbServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(285, 26);
            this.tbServer.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(276, -83);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(448, 36);
            this.label13.TabIndex = 46;
            this.label13.Text = "Backup and Restore application";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(302, 147);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(248, 26);
            this.tbPassword.TabIndex = 49;
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.Location = new System.Drawing.Point(214, 434);
            this.tbPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(282, 28);
            this.tbPath.TabIndex = 6;
            this.tbPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectFile.Location = new System.Drawing.Point(517, 434);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(33, 28);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBackUpPannel
            // 
            this.btnBackUpPannel.BackColor = System.Drawing.Color.Cyan;
            this.btnBackUpPannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUpPannel.Location = new System.Drawing.Point(264, 522);
            this.btnBackUpPannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackUpPannel.Name = "btnBackUpPannel";
            this.btnBackUpPannel.Size = new System.Drawing.Size(200, 30);
            this.btnBackUpPannel.TabIndex = 48;
            this.btnBackUpPannel.Text = "Back Up";
            this.btnBackUpPannel.UseVisualStyleBackColor = false;
            this.btnBackUpPannel.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbBackupCpnt
            // 
            this.cbBackupCpnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBackupCpnt.FormattingEnabled = true;
            this.cbBackupCpnt.Location = new System.Drawing.Point(264, 318);
            this.cbBackupCpnt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBackupCpnt.Name = "cbBackupCpnt";
            this.cbBackupCpnt.Size = new System.Drawing.Size(286, 30);
            this.cbBackupCpnt.TabIndex = 4;
            this.cbBackupCpnt.SelectedIndexChanged += new System.EventHandler(this.cbBackupCpnt_SelectedIndexChanged);
            // 
            // cbAuthen
            // 
            this.cbAuthen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuthen.FormattingEnabled = true;
            this.cbAuthen.Location = new System.Drawing.Point(264, 74);
            this.cbAuthen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAuthen.Name = "cbAuthen";
            this.cbAuthen.Size = new System.Drawing.Size(285, 28);
            this.cbAuthen.TabIndex = 4;
            this.cbAuthen.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbBackupType
            // 
            this.cbBackupType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBackupType.FormattingEnabled = true;
            this.cbBackupType.Location = new System.Drawing.Point(264, 235);
            this.cbBackupType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBackupType.Name = "cbBackupType";
            this.cbBackupType.Size = new System.Drawing.Size(285, 28);
            this.cbBackupType.TabIndex = 4;
            this.cbBackupType.SelectedIndexChanged += new System.EventHandler(this.cbBackupType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 1;
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbFileG
            // 
            this.lbFileG.AutoSize = true;
            this.lbFileG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileG.Location = new System.Drawing.Point(77, 370);
            this.lbFileG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFileG.Name = "lbFileG";
            this.lbFileG.Size = new System.Drawing.Size(161, 24);
            this.lbFileG.TabIndex = 1;
            this.lbFileG.Text = "Filegroups Name:";
            this.lbFileG.Click += new System.EventHandler(this.lbFileG_Click);
            // 
            // lbFilepath
            // 
            this.lbFilepath.AutoSize = true;
            this.lbFilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilepath.Location = new System.Drawing.Point(126, 434);
            this.lbFilepath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilepath.Name = "lbFilepath";
            this.lbFilepath.Size = new System.Drawing.Size(87, 24);
            this.lbFilepath.TabIndex = 1;
            this.lbFilepath.Text = "File path:";
            this.lbFilepath.Click += new System.EventHandler(this.lbFilepath_Click);
            // 
            // lbBackUpcpnt
            // 
            this.lbBackUpcpnt.AutoSize = true;
            this.lbBackUpcpnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBackUpcpnt.Location = new System.Drawing.Point(68, 318);
            this.lbBackUpcpnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBackUpcpnt.Name = "lbBackUpcpnt";
            this.lbBackUpcpnt.Size = new System.Drawing.Size(179, 24);
            this.lbBackUpcpnt.TabIndex = 1;
            this.lbBackUpcpnt.Text = "Backup component:";
            this.lbBackUpcpnt.Click += new System.EventHandler(this.lbBackUpcpnt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Backup type:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(173, 147);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(97, 24);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password:";
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(170, 111);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(102, 24);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username:";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Authentication:";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Server name:";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Database:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 36);
            this.label1.TabIndex = 46;
            this.label1.Text = "Backup and Restore application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Window;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(22, 54);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(206, 28);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back Up";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.SystemColors.Window;
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.Location = new System.Drawing.Point(236, 54);
            this.btnRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(134, 28);
            this.btnRes.TabIndex = 49;
            this.btnRes.Text = "Restore";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.SystemColors.Window;
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSec.Location = new System.Drawing.Point(387, 54);
            this.btnSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(169, 28);
            this.btnSec.TabIndex = 50;
            this.btnSec.Text = "Security";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.Window;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(575, 54);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(133, 28);
            this.btnEncrypt.TabIndex = 51;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 684);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBackup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Backup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.panelBackup.ResumeLayout(false);
            this.panelBackup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panelBackup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnRes;
		private System.Windows.Forms.Button btnSec;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbBackupCpnt;
		private System.Windows.Forms.Label lbBackUpcpnt;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.ComponentModel.Component BackUp;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Button btnBackUpPannel;
		private System.Windows.Forms.ComboBox cbBackupType;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbAuthen;
		private System.Windows.Forms.Label lbFilepath;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.ComboBox cbDatabase;
		private System.Windows.Forms.Label lbFileName;
		private System.Windows.Forms.TextBox tbFileName;
		private System.Windows.Forms.TextBox tbFileG;
		private System.Windows.Forms.Label lbFileG;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

