using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GymSystemProject.Forms
{
		public partial class AdminForm : Form
		{
				private LoginPage loginForm;
				private bool isLoggingOut = false;

				public AdminForm(LoginPage form)
				{
						InitializeComponent();
						loginForm = form;
				}



				private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						if (!isLoggingOut)
						{
								Application.Exit();
						}
				}
				private void btnLogout_Click(object sender, EventArgs e)
				{
						isLoggingOut = true;
						loginForm.ResetFields();
						loginForm.ShowAgain();
						this.Close();
				}

		}
}
