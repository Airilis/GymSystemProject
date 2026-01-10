namespace GymSystemProject.Forms
{
		partial class MonthCalendarForm
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
						monthCalendar = new MonthCalendar();
						lblDayStatus = new Label();
						btnNext = new Button();
						label1 = new Label();
						SuspendLayout();
						// 
						// monthCalendar
						// 
						monthCalendar.Location = new Point(299, 99);
						monthCalendar.Name = "monthCalendar";
						monthCalendar.TabIndex = 0;
						// 
						// lblDayStatus
						// 
						lblDayStatus.AutoSize = true;
						lblDayStatus.Location = new Point(369, 324);
						lblDayStatus.Name = "lblDayStatus";
						lblDayStatus.Size = new Size(50, 20);
						lblDayStatus.TabIndex = 1;
						lblDayStatus.Text = "label1";
						lblDayStatus.Visible = false;
						// 
						// btnNext
						// 
						btnNext.Location = new Point(351, 368);
						btnNext.Name = "btnNext";
						btnNext.Size = new Size(94, 29);
						btnNext.TabIndex = 2;
						btnNext.Text = "Next";
						btnNext.UseVisualStyleBackColor = true;
						btnNext.Click += btnNext_Click;
						// 
						// label1
						// 
						label1.AutoSize = true;
						label1.Location = new Point(347, 60);
						label1.Name = "label1";
						label1.Size = new Size(98, 20);
						label1.TabIndex = 3;
						label1.Text = "Choose a day";
						// 
						// MonthCalendarForm
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						ClientSize = new Size(800, 450);
						Controls.Add(label1);
						Controls.Add(btnNext);
						Controls.Add(lblDayStatus);
						Controls.Add(monthCalendar);
						Name = "MonthCalendarForm";
						Text = "MonthCalendarForm";
						Load += MonthCalendarForm_Load;
						ResumeLayout(false);
						PerformLayout();
				}

				#endregion

				private MonthCalendar monthCalendar;
				private Label lblDayStatus;
				private Button btnNext;
				private Label label1;
		}
}