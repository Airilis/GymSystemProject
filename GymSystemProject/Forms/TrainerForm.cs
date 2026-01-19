using GymSystemProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystemProject.Forms
{
		public partial class TrainerForm : Form
		{
				private EnrollmentalData data;
				//	private Form userForm;
				private Form previousForm;
			//	private LoginPage loginForm;
				//private bool isLoggingOut = false;
				public TrainerForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;
						//	this.userForm = userForm;
						this.previousForm = previousForm;

				}
				private void TrainerForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						Application.Exit();
				}


				private void btnNext_Click(object sender, EventArgs e)
				{
						if (listBoxTrainer.SelectedItem == null)
						{
								MessageBox.Show("Выберите тренера");
								return;
						}
						data.Trainer = listBoxTrainer.SelectedItem.ToString();

						MonthCalendarForm calendarForm = new MonthCalendarForm(data, this);
						calendarForm.Show();
						this.Hide();
				}

				private void listBoxTrainer_SelectedIndexChanged(object sender, EventArgs e)
				{

				}

				private void btnBack_Click(object sender, EventArgs e)
				{
						if (previousForm != null)
						{
								this.Hide();
								previousForm.Show();
						}
						else
						{
								MessageBox.Show("Предыдущая форма недоступна");
						}
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
		}
}
