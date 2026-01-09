using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using GymSystemProject.Models;

namespace GymSystemProject.Forms
{
		public partial class UserForm : Form
		{
				private string currentUser;
				private LoginPage loginForm;
				private bool isLoggingOut = false;
				private List<Training> allTrainings = new List<Training>();
				private List<UserTraining> userTrainings = new List<UserTraining>();

				public UserForm(string login, LoginPage form)
				{
						InitializeComponent();
						currentUser = login;
						loginForm = form;
				}

				private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
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
