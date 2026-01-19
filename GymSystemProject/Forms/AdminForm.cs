using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GymSystemProject.Forms
{
		public partial class AdminForm : Form
		{
				private LoginPage loginForm;
				private bool isLoggingOut = false;

				public AdminForm(LoginPage form)
				{
						InitializeComponent();
						loginForm = form;
				}



				private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
				{

						Application.Exit();

				}
				private void btnLogout_Click(object sender, EventArgs e)
				{
						isLoggingOut = true;
						loginForm.ResetFields();
						loginForm.ShowAgain();
						this.Hide();
				}

				private void btnGenerateReport_Click(object sender, EventArgs e)
				{
						try
						{
								string baseDir = AppDomain.CurrentDomain.BaseDirectory;
								string dataDir = Path.Combine(baseDir, "Data");

								string pythonExe = "python"; // если python в PATH
								string scriptPath = Path.Combine(dataDir, "analyzer.py");

								string reportPath = Path.Combine(dataDir, "report.txt");

								if (!File.Exists(scriptPath))
								{
										MessageBox.Show("Файл analyzer.py не найден");
										return;
								}

								// 1️⃣ Запуск Python-скрипта
								ProcessStartInfo psi = new ProcessStartInfo
								{
										FileName = pythonExe,
										Arguments = $"\"{scriptPath}\"",
										WorkingDirectory = dataDir,
										UseShellExecute = false,
										CreateNoWindow = true
								};

								Process process = Process.Start(psi);
								process.WaitForExit();

								// 2️⃣ Открытие отчёта
								if (File.Exists(reportPath))
								{
										Process.Start(new ProcessStartInfo
										{
												FileName = reportPath,
												UseShellExecute = true
										});
								}
								else
								{
										MessageBox.Show("Отчёт не был создан");
								}
						}
						catch (Exception ex)
						{
								MessageBox.Show("Ошибка при создании отчёта:\n" + ex.Message);
						}
				}
		}
}
