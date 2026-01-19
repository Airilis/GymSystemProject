using GymSystemProject.Models;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace GymSystemProject.Forms
{
		public partial class MonthCalendarForm : Form
		{
				private EnrollmentalData data;
				private Form previousForm;

				public MonthCalendarForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;
						this.previousForm = previousForm;
						this.StartPosition = FormStartPosition.CenterScreen;

						// Set calendar and UI culture to English
						Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
						Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
				}

				private void MonthCalendarForm_Load(object sender, EventArgs e)
				{
						if (!data.MembershipActive)
						{
								MessageBox.Show(
												"You do not have an active membership.",
												"Error",
												MessageBoxButtons.OK,
												MessageBoxIcon.Warning
								);

								btnNext.Enabled = false;
								return;
						}

						monthCalendar.MinDate = DateTime.Today;
						monthCalendar.MaxDate = data.MembershipEndDate.Date;
				}

				private void MonthCalendarForm_FormClosed(object sender, FormClosedEventArgs e)
				{
						Application.Exit();
				}

				private void btnNext_Click(object sender, EventArgs e)
				{
						DateTime selectedDate = monthCalendar.SelectionStart.Date;

						if (selectedDate > data.MembershipEndDate.Date)
						{
								MessageBox.Show(
												$"Your membership is valid until {data.MembershipEndDate:dd.MM.yyyy}.\n" +
												"The selected date is not available.",
												"Membership Expired",
												MessageBoxButtons.OK,
												MessageBoxIcon.Warning
								);
								return;
						}

						data.TrainingDate = selectedDate;

						ConfirmForm confirmForm = new ConfirmForm(data, this);
						confirmForm.Show();
						this.Hide();
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

				private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
				{
						// Currently no action
				}
		}
}
