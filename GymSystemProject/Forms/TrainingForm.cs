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

				private void btnNext_Click(object sender, EventArgs e)
				{
						if (listBoxTrainings.SelectedItem == null)
						{
								MessageBox.Show("Выберите тренировку");
								return;
						}

						data.Training = listBoxTrainings.SelectedItem.ToString();

						TrainerForm trainerForm = new TrainerForm(data);
						trainerForm.Show();
						this.Hide();
				}
		}
}
