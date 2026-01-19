using GymSystemProject.Models;
using System;
using System.Windows.Forms;
using GymSystemProject.Services;

namespace GymSystemProject.Forms
{
		public partial class ConfirmForm : Form
		{
				private EnrollmentalData data;
				private Form previousForm;

				public ConfirmForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;
						this.previousForm = previousForm;
						this.StartPosition = FormStartPosition.CenterScreen;

						lblSummary.Text =
										$"User: {data.UserLogin}\n" +
										$"Membership: {(data.MembershipActive ? "Active" : "Inactive")}\n" +
										$"Training: {data.Training}\n" +
										$"Trainer: {data.Trainer}\n" +
										$"Date: {data.TrainingDate:dd.MM.yyyy}";
				}

				private void ConfirmForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						Application.Exit();
				}

				private void btnConfirm_Click(object sender, EventArgs e)
				{
						EnrollmentRecord record = new EnrollmentRecord
						{
								UserLogin = data.UserLogin,
								Training = data.Training,
								Trainer = data.Trainer,
								TrainingDate = data.TrainingDate,
								MembershipEndDate = data.MembershipEndDate
						};

						JsonStorage.SaveEnrollment(record);

						MessageBox.Show(
										"You have successfully enrolled in the training!",
										"Done",
										MessageBoxButtons.OK,
										MessageBoxIcon.Information
						);

						// Return to UserForm
						data.UserForm.Show();

						// Close this form
						this.Close();
				}

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

				private void btnBack_Click(object sender, EventArgs e)
				{
						if (previousForm != null)
						{
								this.Hide();
								previousForm.Show();
						}
						else
						{
								MessageBox.Show("Previous form is unavailable");
						}
				}

				private void label1_Click(object sender, EventArgs e)
				{
						// Currently no action
				}
		}
}
