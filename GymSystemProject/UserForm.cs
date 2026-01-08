using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystemProject
{
		public partial class UserForm : Form
		{
				private string currentUser;
				public UserForm(string login)
				{
						InitializeComponent();
						currentUser = login;
				}

				private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						Application.Exit();
				}
		}
}
