using GymSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace GymSystemProject.Forms
{

		public partial class UserForm : Form
		{
				private string currentUser;
				private EnrollmentalData data;
				private LoginPage loginForm;
				public UserForm(EnrollmentalData data)
				{
						InitializeComponent();
						this.data = data;
				}

				private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
				{						
								Application.Exit();						
				}

				private void btnLogout_Click(object sender, EventArgs e)
				{
						if (data.LoginForm == null)
						{
								MessageBox.Show("LoginForm = null (ошибка передачи данных)");
								return;
						}
						data.LoginForm.ResetFields();
						data.LoginForm.Show();
						this.Hide();
				}

				private void btnEnroll_Click(object sender, EventArgs e)
				{
						
						data.UserForm = this;
						MembershipForm membershipForm = new MembershipForm(data,this);
						membershipForm.Show();
						this.Hide();
				}
		}
}
