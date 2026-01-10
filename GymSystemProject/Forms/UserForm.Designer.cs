namespace GymSystemProject.Forms
{
		partial class UserForm
		{
				/// <summary>
				/// Required designer variable.
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				/// Clean up any resources being used.
				/// </summary>
				/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
				protected override void Dispose(bool disposing)
				{
						if (disposing && (components != null))
						{
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Windows Form Designer generated code

				/// <summary>
				/// Required method for Designer support - do not modify
				/// the contents of this method with the code editor.
				/// </summary>
				private void InitializeComponent()
				{
						log_out = new Button();
						btnEnroll = new Button();
						SuspendLayout();
						// 
						// log_out
						// 
						log_out.Location = new Point(675, 12);
						log_out.Name = "log_out";
						log_out.Size = new Size(94, 29);
						log_out.TabIndex = 0;
						log_out.Text = "log out";
						log_out.UseVisualStyleBackColor = true;
						log_out.Click += btnLogout_Click;
						// 
						// btnEnroll
						// 
						btnEnroll.Location = new Point(354, 172);
						btnEnroll.Name = "btnEnroll";
						btnEnroll.Size = new Size(94, 29);
						btnEnroll.TabIndex = 1;
						btnEnroll.Text = "Enroll";
						btnEnroll.UseVisualStyleBackColor = true;
						btnEnroll.Click += btnEnroll_Click;
						// 
						// UserForm
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						ClientSize = new Size(800, 450);
						Controls.Add(btnEnroll);
						Controls.Add(log_out);
						Name = "UserForm";
						Text = "UserForm";
						FormClosed += UserForm_FormClosed;
						ResumeLayout(false);
				}

				#endregion

				private Button log_out;
				private Button btnEnroll;
		}
}