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
using GymSystemProject.Services;
namespace GymSystemProject.Forms
{
		public partial class ConfirmForm : Form
		{
				private Form userForm;
				private EnrollmentalData data;
				private Form previousForm;

				public ConfirmForm(EnrollmentalData data, Form previousForm)
				{
						InitializeComponent();
						this.data = data;
						//this.userForm = userForm;
						this.previousForm = previousForm;

						lblSummary.Text =
										$"Пользователь: {data.UserLogin}\n" +
										$"Абонемент: {(data.MembershipActive ? "Активен" : "Не активен")}\n" +
										$"Тренировка: {data.Training}\n" +
										$"Тренер: {data.Trainer}\n" +
										$"Дата: {data.TrainingDate:dd.MM.yyyy}";
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
										"Вы успешно записаны на тренировку!",
										"Готово",
										MessageBoxButtons.OK,
										MessageBoxIcon.Information
						);

						// Возвращаемся на UserForm
						data.UserForm.Show();

						// Закрываем всю цепочку
						this.Close();
				}

		}
}
