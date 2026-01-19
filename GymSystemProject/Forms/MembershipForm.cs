using GymSystemProject.Models;
using System;
using System.Windows.Forms;

namespace GymSystemProject.Forms
{
		public partial class MembershipForm : Form
		{
				private EnrollmentalData data;
				private Form previousForm;

				public MembershipForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;
						this.previousForm = previousForm;
						this.StartPosition = FormStartPosition.CenterScreen;
				}

				// Called when form is shown
				private void MembershipForm_Shown(object sender, EventArgs e)
				{
						lblMembershipStatus.Text = "";
						chkBuyMembership.Visible = false;
						btnNext.Visible = false;

						if (data.MembershipActive &&
										data.MembershipEndDate != DateTime.MinValue &&
										data.MembershipEndDate > DateTime.Now)
						{
								ShowActiveMembership();
						}
						else
						{
								ShowNoMembership();
						}
				}

				private void MembershipForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						Application.Exit();
				}

				// Display active membership info
				private void ShowActiveMembership()
				{
						TimeSpan remaining = data.MembershipEndDate - DateTime.Now;

						lblMembershipStatus.Text =
										$"Membership active\n" +
										$"Days remaining: {remaining.Days}";

						chkBuyMembership.Visible = false;
						btnNext.Visible = true;
				}

				// Display message for users without membership
				private void ShowNoMembership()
				{
						lblMembershipStatus.Text =
										"No membership found.\n" +
										"You need to purchase a 90-day membership.";

						chkBuyMembership.Visible = true;
						btnNext.Visible = false;
				}

				private void dtpMembershipEnd_ValueChanged(object sender, EventArgs e)
				{
						// Currently no action
				}

				private void btnNext_Click(object sender, EventArgs e)
				{
						TrainingForm trainingForm = new TrainingForm(data, this);
						trainingForm.Show();
						this.Hide();
				}

				private void chkBuyMembership_CheckedChanged(object sender, EventArgs e)
				{
						if (chkBuyMembership.Checked)
						{
								data.MembershipActive = true;
								data.MembershipEndDate = DateTime.Now.AddDays(90);

								btnNext.Visible = true;
						}
						else
						{
								btnNext.Visible = false;
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

				private void lblMembershipStatus_Click(object sender, EventArgs e)
				{
						// Currently no action
				}
		}
}
