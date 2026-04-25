namespace HQTCSDL
{
	partial class Security
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
			this.cbDatabase = new System.Windows.Forms.ComboBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.cbAuthen = new System.Windows.Forms.ComboBox();
			this.lbPassword = new System.Windows.Forms.Label();
			this.lbUsername = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSec = new System.Windows.Forms.Button();
			this.btnRes = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.btnDeny = new System.Windows.Forms.Button();
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.cbPermissions = new System.Windows.Forms.ComboBox();
			this.btnGrant = new System.Windows.Forms.Button();
			this.btnRevoke = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEncrypt = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// cbDatabase
			// 
			this.cbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDatabase.FormattingEnabled = true;
			this.cbDatabase.Location = new System.Drawing.Point(366, 330);
			this.cbDatabase.Name = "cbDatabase";
			this.cbDatabase.Size = new System.Drawing.Size(379, 33);
			this.cbDatabase.TabIndex = 87;
			this.cbDatabase.SelectedIndexChanged += new System.EventHandler(this.cbDatabase_SelectedIndexChanged);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(783, 134);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(97, 30);
			this.btnConnect.TabIndex = 86;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// tbUsername
			// 
			this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsername.Location = new System.Drawing.Point(415, 228);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(330, 30);
			this.tbUsername.TabIndex = 83;
			// 
			// tbServer
			// 
			this.tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbServer.Location = new System.Drawing.Point(366, 133);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(379, 30);
			this.tbServer.TabIndex = 84;
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.Location = new System.Drawing.Point(415, 272);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(329, 30);
			this.tbPassword.TabIndex = 85;
			// 
			// cbAuthen
			// 
			this.cbAuthen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAuthen.FormattingEnabled = true;
			this.cbAuthen.Location = new System.Drawing.Point(365, 182);
			this.cbAuthen.Name = "cbAuthen";
			this.cbAuthen.Size = new System.Drawing.Size(379, 33);
			this.cbAuthen.TabIndex = 82;
			this.cbAuthen.SelectedIndexChanged += new System.EventHandler(this.cbAuthen_SelectedIndexChanged);
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPassword.Location = new System.Drawing.Point(244, 272);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(126, 29);
			this.lbPassword.TabIndex = 77;
			this.lbPassword.Text = "Password:";
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.Location = new System.Drawing.Point(240, 228);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(130, 29);
			this.lbUsername.TabIndex = 78;
			this.lbUsername.Text = "Username:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(160, 182);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(169, 29);
			this.label7.TabIndex = 79;
			this.label7.Text = "Authentication:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(173, 134);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(156, 29);
			this.label10.TabIndex = 80;
			this.label10.Text = "Server name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(201, 334);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 29);
			this.label4.TabIndex = 81;
			this.label4.Text = "Database:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(35, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 36);
			this.label3.TabIndex = 76;
			this.label3.Text = "Source";
			// 
			// btnSec
			// 
			this.btnSec.BackColor = System.Drawing.SystemColors.Window;
			this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSec.Location = new System.Drawing.Point(512, 58);
			this.btnSec.Name = "btnSec";
			this.btnSec.Size = new System.Drawing.Size(211, 40);
			this.btnSec.TabIndex = 75;
			this.btnSec.Text = "Security";
			this.btnSec.UseVisualStyleBackColor = false;
			// 
			// btnRes
			// 
			this.btnRes.BackColor = System.Drawing.SystemColors.Window;
			this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRes.Location = new System.Drawing.Point(260, 56);
			this.btnRes.Name = "btnRes";
			this.btnRes.Size = new System.Drawing.Size(223, 40);
			this.btnRes.TabIndex = 74;
			this.btnRes.Text = "Restore";
			this.btnRes.UseVisualStyleBackColor = false;
			this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.SystemColors.Window;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(40, 55);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(193, 40);
			this.btnBack.TabIndex = 73;
			this.btnBack.Text = "Back Up";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(267, 398);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 16);
			this.label1.TabIndex = 72;
			this.label1.Text = "Tên user được chọn:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(401, 395);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(242, 22);
			this.txtUsername.TabIndex = 71;
			// 
			// btnDeny
			// 
			this.btnDeny.Location = new System.Drawing.Point(670, 628);
			this.btnDeny.Name = "btnDeny";
			this.btnDeny.Size = new System.Drawing.Size(75, 28);
			this.btnDeny.TabIndex = 70;
			this.btnDeny.Text = "Từ chối";
			this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
			// 
			// dgvUsers
			// 
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.Location = new System.Drawing.Point(270, 421);
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.RowHeadersWidth = 51;
			this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsers.Size = new System.Drawing.Size(475, 202);
			this.dgvUsers.TabIndex = 65;
			this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
			this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
			// 
			// cbPermissions
			// 
			this.cbPermissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPermissions.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE",
            "BACKUP DATABASE"});
			this.cbPermissions.Location = new System.Drawing.Point(270, 632);
			this.cbPermissions.Name = "cbPermissions";
			this.cbPermissions.Size = new System.Drawing.Size(213, 24);
			this.cbPermissions.TabIndex = 66;
			// 
			// btnGrant
			// 
			this.btnGrant.Location = new System.Drawing.Point(489, 628);
			this.btnGrant.Name = "btnGrant";
			this.btnGrant.Size = new System.Drawing.Size(94, 28);
			this.btnGrant.TabIndex = 67;
			this.btnGrant.Text = "Cấp quyền";
			// 
			// btnRevoke
			// 
			this.btnRevoke.Location = new System.Drawing.Point(589, 628);
			this.btnRevoke.Name = "btnRevoke";
			this.btnRevoke.Size = new System.Drawing.Size(75, 28);
			this.btnRevoke.TabIndex = 68;
			this.btnRevoke.Text = "Thu hồi quyền";
			this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(652, 393);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(93, 27);
			this.btnRefresh.TabIndex = 69;
			this.btnRefresh.Text = "Xem quyền";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(237, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(546, 44);
			this.label2.TabIndex = 88;
			this.label2.Text = "Backup and Restore application";
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEncrypt.Location = new System.Drawing.Point(783, 55);
			this.btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(191, 46);
			this.btnEncrypt.TabIndex = 89;
			this.btnEncrypt.Text = "Encrypt";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// Security
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(996, 673);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbDatabase);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.cbAuthen);
			this.Controls.Add(this.lbPassword);
			this.Controls.Add(this.lbUsername);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnSec);
			this.Controls.Add(this.btnRes);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.btnDeny);
			this.Controls.Add(this.dgvUsers);
			this.Controls.Add(this.cbPermissions);
			this.Controls.Add(this.btnGrant);
			this.Controls.Add(this.btnRevoke);
			this.Controls.Add(this.btnRefresh);
			this.Name = "Security";
			this.Text = "Security";
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbDatabase;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.ComboBox cbAuthen;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSec;
		private System.Windows.Forms.Button btnRes;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Button btnDeny;
		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.ComboBox cbPermissions;
		private System.Windows.Forms.Button btnGrant;
		private System.Windows.Forms.Button btnRevoke;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEncrypt;
	}
}