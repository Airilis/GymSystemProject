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
		public partial class TrainingForm : Form
		{
				private EnrollmentalData data;
				//private Form userForm;
				private Form previousForm;
				//private LoginPage loginForm;
				//private bool isLoggingOut = false;
				public TrainingForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;
						//this.userForm = userForm;
						this.previousForm = previousForm;
				}

				private void listBoxTrainings_SelectedIndexChanged(object sender, EventArgs e)
				{

				}
				private void TrainingForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						Application.Exit();
				}
				private void btnNext_Click(object sender, EventArgs e)
				{
						if (listBoxTrainings.SelectedItem == null)
						{
								MessageBox.Show("Выберите тренировку");
								return;
						}

						data.Training = listBoxTrainings.SelectedItem.ToString();

						TrainerForm trainerForm = new TrainerForm(data,this);
						trainerForm.Show();
						this.Hide();
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
