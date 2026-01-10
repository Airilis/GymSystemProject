namespace GymSystemProject.Forms
{
		partial class TrainingForm
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
						trainingChoice = new Label();
						listBoxTrainings = new ListBox();
						btnNext = new Button();
						SuspendLayout();
						// 
						// trainingChoice
						// 
						trainingChoice.AutoSize = true;
						trainingChoice.Location = new Point(310, 46);
						trainingChoice.Name = "trainingChoice";
						trainingChoice.Size = new Size(125, 20);
						trainingChoice.TabIndex = 0;
						trainingChoice.Text = "Choose a training";
						// 
						// listBoxTrainings
						// 
						listBoxTrainings.FormattingEnabled = true;
						listBoxTrainings.Items.AddRange(new object[] { "Yoga", "Boxing", "Pilates" });
						listBoxTrainings.Location = new Point(300, 146);
						listBoxTrainings.Name = "listBoxTrainings";
						listBoxTrainings.Size = new Size(150, 64);
						listBoxTrainings.TabIndex = 1;
						listBoxTrainings.SelectedIndexChanged += listBoxTrainings_SelectedIndexChanged;
						// 
						// btnNext
						// 
						btnNext.Location = new Point(329, 295);
						btnNext.Name = "btnNext";
						btnNext.Size = new Size(94, 29);
						btnNext.TabIndex = 2;
						btnNext.Text = "Next";
						btnNext.UseVisualStyleBackColor = true;
						btnNext.Click += btnNext_Click;
						// 
						// TrainingForm
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						ClientSize = new Size(800, 450);
						Controls.Add(btnNext);
						Controls.Add(listBoxTrainings);
						Controls.Add(trainingChoice);
						Name = "TrainingForm";
						Text = "TrainingForm";
						ResumeLayout(false);
						PerformLayout();
				}

				#endregion

				private Label trainingChoice;
				private ListBox listBoxTrainings;
				private Button btnNext;
		}
}