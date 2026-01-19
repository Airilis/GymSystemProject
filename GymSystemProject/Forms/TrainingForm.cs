using GymSystemProject.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymSystemProject.Forms
{
		public partial class TrainingForm : Form
		{
				private EnrollmentalData data;
				private Form previousForm;

				public TrainingForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;
						this.previousForm = previousForm;
						this.StartPosition = FormStartPosition.CenterScreen;
				}

				private void listBoxTrainings_SelectedIndexChanged(object sender, EventArgs e)
				{
						// Currently no action
				}

				private void TrainingForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						Application.Exit();
				}

				// Next button: save selected training and go to trainer selection
				private void btnNext_Click(object sender, EventArgs e)
				{
						if (listBoxTrainings.SelectedItem == null)
						{
								MessageBox.Show("Please select a training", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
						}

						data.Training = listBoxTrainings.SelectedItem.ToString();

						TrainerForm trainerForm = new TrainerForm(data, this);
						trainerForm.Show();
						this.Hide();
				}

				// Back button: return to previous form
				private void btnBack_Click(object sender, EventArgs e)
				{
						if (previousForm != null)
						{
								this.Hide();
								previousForm.Show();
						}
						else
						{
								MessageBox.Show("Previous form unavailable");
						}
				}

				// Logout button: return to login form
				private void btnLogout_Click(object sender, EventArgs e)
				{
						if (data.LoginForm == null)
						{
								MessageBox.Show("LoginForm is null (data transfer error)");
								return;
						}

						data.LoginForm.ResetFields();
						data.LoginForm.Show();
						this.Hide();
				}
		}
}
