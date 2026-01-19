using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

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
						this.StartPosition = FormStartPosition.CenterScreen;
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

								string pythonExe = "python"; // assuming python is in PATH
								string scriptPath = Path.Combine(dataDir, "analyzer.py");

								string reportPath = Path.Combine(dataDir, "report.txt");

								if (!File.Exists(scriptPath))
								{
										MessageBox.Show("Analyzer.py file not found");
										return;
								}

								//  Run Python script
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

								//  Open report
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
										MessageBox.Show("Report was not created");
								}
						}
						catch (Exception ex)
						{
								MessageBox.Show("Error generating report:\n" + ex.Message);
						}
				}
		}
}
