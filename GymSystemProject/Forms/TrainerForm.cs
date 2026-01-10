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

				public TrainerForm(EnrollmentalData data)
				{
						InitializeComponent();
						this.data = data;
					//	this.userForm = userForm;
						this.previousForm = previousForm;

				}

				private void comboBoxTrainers_SelectedIndexChanged(object sender, EventArgs e)
				{

				}

				private void btnNext_Click(object sender, EventArgs e)
				{
						if (comboBoxTrainers.SelectedItem == null)
						{
								MessageBox.Show("Выберите тренера");
								return;
						}
						data.Trainer = comboBoxTrainers.SelectedItem.ToString();

						MonthCalendarForm calendarForm = new MonthCalendarForm(data, this);
						calendarForm.Show();
						this.Hide();
				}
		}
}
