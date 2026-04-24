using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQTCSDL
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			tbPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
		}

		private void tbUsername_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{

		}
	}
}
