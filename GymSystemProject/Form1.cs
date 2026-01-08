

namespace GymSystemProject
{
		public partial class LoginPage : Form
		{
				public LoginPage()
				{
						InitializeComponent();
				}

				private void btnLogin_Click(object sender, EventArgs e)
				{
						string login = txtLogin.Text;
						string password = txtPassword.Text;
						//MessageBox.Show($"Login: {login}\nPassword: {password}");
						if (login == "admin")
						{
								AdminForm adminForm=new AdminForm();
								adminForm.Show();
						}
						else
						{
								UserForm userForm=new UserForm(login);
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
