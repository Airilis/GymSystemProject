namespace GymSystemProject.Forms
{
		partial class TrainerForm
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
						label1 = new Label();
						btnNext = new Button();
						listBoxTrainer = new ListBox();
						SuspendLayout();
						// 
						// label1
						// 
						label1.AutoSize = true;
						label1.Location = new Point(337, 58);
						label1.Name = "label1";
						label1.Size = new Size(117, 20);
						label1.TabIndex = 0;
						label1.Text = "Choose a trainer";
						// 
						// btnNext
						// 
						btnNext.Location = new Point(346, 244);
						btnNext.Name = "btnNext";
						btnNext.Size = new Size(94, 29);
						btnNext.TabIndex = 2;
						btnNext.Text = "Next";
						btnNext.UseVisualStyleBackColor = true;
						btnNext.Click += btnNext_Click;
						// 
						// listBoxTrainer
						// 
						listBoxTrainer.FormattingEnabled = true;
						listBoxTrainer.Items.AddRange(new object[] { "Alfa", "Betta", "Gamma", "Delta" });
						listBoxTrainer.Location = new Point(346, 115);
						listBoxTrainer.Name = "listBoxTrainer";
						listBoxTrainer.Size = new Size(82, 84);
						listBoxTrainer.TabIndex = 3;
						listBoxTrainer.SelectedIndexChanged += listBoxTrainer_SelectedIndexChanged;
						// 
						// TrainerForm
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						ClientSize = new Size(800, 450);
						Controls.Add(listBoxTrainer);
						Controls.Add(btnNext);
						Controls.Add(label1);
						Name = "TrainerForm";
						Text = "TrainerForm";
						ResumeLayout(false);
						PerformLayout();
				}

				#endregion

				private Label label1;
				private Button btnNext;
				private ListBox listBoxTrainer;
		}
}