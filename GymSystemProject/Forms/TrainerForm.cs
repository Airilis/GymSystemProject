using GymSystemProject.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymSystemProject.Forms
{
		public partial class TrainerForm : Form
		{
				private EnrollmentalData data;
				private Form previousForm;

				public TrainerForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;
						this.previousForm = previousForm;
						this.StartPosition = FormStartPosition.CenterScreen;
				}

				private void TrainerForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						Application.Exit();
				}

				// Next button: save selected trainer and go to calendar
				private void btnNext_Click(object sender, EventArgs e)
				{
						if (listBoxTrainer.SelectedItem == null)
						{
								MessageBox.Show("Please select a trainer", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
						}

						data.Trainer = listBoxTrainer.SelectedItem.ToString();

						MonthCalendarForm calendarForm = new MonthCalendarForm(data, this);
						calendarForm.Show();
						this.Hide();
				}

				private void listBoxTrainer_SelectedIndexChanged(object sender, EventArgs e)
				{
						// Currently no action
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
