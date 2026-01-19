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
		public partial class MonthCalendarForm : Form
		{
				private EnrollmentalData data;

				private Form previousForm;
			//	private LoginPage loginForm;
				//private bool isLoggingOut = false;
				public MonthCalendarForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;

						this.previousForm = previousForm;

				}
				private void MonthCalendarForm_Load(object sender, EventArgs e)
				{
						if (!data.MembershipActive)
						{
								MessageBox.Show(
												"У вас нет активного абонемента.",
												"Ошибка",
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
												$"Абонемент действует до {data.MembershipEndDate:dd.MM.yyyy}.\n" +
												"Выбранная дата недоступна.",
												"Абонемент истёк",
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
		}
}
