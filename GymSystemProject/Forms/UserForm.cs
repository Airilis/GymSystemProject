using GymSystemProject.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymSystemProject.Forms
{
		public partial class UserForm : Form
		{
				private EnrollmentalData data;

				public UserForm(EnrollmentalData data)
				{
						InitializeComponent();
						this.data = data;
						this.StartPosition = FormStartPosition.CenterScreen;
				}

				private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						// Exit the application when this form is closed
						Application.Exit();
				}

				// Logout button: return to login form
				private void btnLogout_Click(object sender, EventArgs e)
				{
						if (data.LoginForm == null)
						{
								MessageBox.Show("LoginForm is null (data transfer error)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
						}

						data.LoginForm.ResetFields();
						data.LoginForm.Show();
						this.Hide();
				}

				// Enroll button: go to MembershipForm
				private void btnEnroll_Click(object sender, EventArgs e)
				{
						data.UserForm = this;
						MembershipForm membershipForm = new MembershipForm(data, this);
						membershipForm.Show();
						this.Hide();
				}
		}
}
