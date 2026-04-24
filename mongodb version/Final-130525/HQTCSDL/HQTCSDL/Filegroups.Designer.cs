namespace HQTCSDL
{
	partial class Filegroups
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.btbClearAll = new System.Windows.Forms.Button();
			this.btnSelectAll = new System.Windows.Forms.Button();
			this.treeViewFileGroups = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(627, 396);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(133, 38);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(464, 398);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(133, 35);
			this.btnOk.TabIndex = 8;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btbClearAll
			// 
			this.btbClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btbClearAll.Location = new System.Drawing.Point(214, 321);
			this.btbClearAll.Name = "btbClearAll";
			this.btbClearAll.Size = new System.Drawing.Size(133, 33);
			this.btbClearAll.TabIndex = 7;
			this.btbClearAll.Text = "Clear All";
			this.btbClearAll.UseVisualStyleBackColor = true;
			this.btbClearAll.Click += new System.EventHandler(this.btbClearAll_Click);
			// 
			// btnSelectAll
			// 
			this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelectAll.Location = new System.Drawing.Point(55, 321);
			this.btnSelectAll.Name = "btnSelectAll";
			this.btnSelectAll.Size = new System.Drawing.Size(133, 33);
			this.btnSelectAll.TabIndex = 6;
			this.btnSelectAll.Text = "Select All";
			this.btnSelectAll.UseVisualStyleBackColor = true;
			this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
			// 
			// treeViewFileGroups
			// 
			this.treeViewFileGroups.Location = new System.Drawing.Point(40, 16);
			this.treeViewFileGroups.Name = "treeViewFileGroups";
			this.treeViewFileGroups.Size = new System.Drawing.Size(663, 283);
			this.treeViewFileGroups.TabIndex = 5;
			// 
			// Filegroups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btbClearAll);
			this.Controls.Add(this.btnSelectAll);
			this.Controls.Add(this.treeViewFileGroups);
			this.Name = "Filegroups";
			this.Text = "Filegroups";
			this.Load += new System.EventHandler(this.Filegroups_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btbClearAll;
		private System.Windows.Forms.Button btnSelectAll;
		private System.Windows.Forms.TreeView treeViewFileGroups;
	}
}