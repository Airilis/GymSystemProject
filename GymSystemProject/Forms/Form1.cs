

using GymSystemProject.Models;

namespace GymSystemProject.Forms
{
		public partial class LoginPage : Form
		{
				public LoginPage()
				{
						InitializeComponent();
				}
				public void ShowAgain()
				{
						this.Show();
				}
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
						//MessageBox.Show($"Login: {login}\nPassword: {password}");
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

				}

				private void txtLogin_TextChanged(object sender, EventArgs e)
				{

				}
		}
}
