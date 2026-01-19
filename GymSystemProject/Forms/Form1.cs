using GymSystemProject.Models;
using System;
using System.Windows.Forms;

namespace GymSystemProject.Forms
{
		public partial class LoginPage : Form
		{
				public LoginPage()
				{
						InitializeComponent();
						this.StartPosition = FormStartPosition.CenterScreen;
				}

				// Show the login form again (used after logout)
				public void ShowAgain()
				{
						this.Show();
				}

				// Clear login and password fields
				public void ResetFields()
				{
						txtLogin.Clear();
						txtPassword.Clear();
						txtLogin.Focus();
				}

				private void btnLogin_Click(object sender, EventArgs e)
				{
						string login = txtLogin.Text;
						string password = txtPassword.Text;

						// For now, login is simple: "admin" opens AdminForm, others open UserForm
						if (login == "admin")
						{
								AdminForm adminForm = new AdminForm(this);
								adminForm.Show();
						}
						else
						{
								EnrollmentalData data = new EnrollmentalData
								{
										UserLogin = login,
										LoginForm = this
								};
								UserForm userForm = new UserForm(data);
								userForm.Show();
						}

						this.Hide();
				}

				private void txtPassword_TextChanged(object sender, EventArgs e)
				{
						// Currently no action
				}

				private void txtLogin_TextChanged(object sender, EventArgs e)
				{
						// Currently no action
				}
		}
}
