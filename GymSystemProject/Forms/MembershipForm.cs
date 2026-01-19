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
		public partial class MembershipForm : Form
		{
				private EnrollmentalData data;
				//	private Form userForm;
				//private bool membershipActive = false;
				private Form previousForm;
			//	private LoginPage loginForm;
				//private bool isLoggingOut = false;

				public MembershipForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;
						this.previousForm = previousForm;

				}
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
				private void ShowActiveMembership()
				{
						TimeSpan remaining = data.MembershipEndDate - DateTime.Now;

						lblMembershipStatus.Text =
										$"Абонемент активен\n" +
										$"Осталось дней: {remaining.Days}";

						chkBuyMembership.Visible = false;
						btnNext.Visible = true;
				}
				private void ShowNoMembership()
				{
						lblMembershipStatus.Text =
										"Абонемент отсутствует.\n" +
										"Необходимо купить абонемент на 90 дней.";

						chkBuyMembership.Visible = true;
						btnNext.Visible = false;
				}

				private void dtpMembershipEnd_ValueChanged(object sender, EventArgs e)
				{

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

				private void lblMembershipStatus_Click(object sender, EventArgs e)
				{

				}
		}
}
