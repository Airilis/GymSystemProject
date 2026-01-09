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
						label1 = new Label();
						listBox1 = new ListBox();
						button1 = new Button();
						SuspendLayout();
						// 
						// label1
						// 
						label1.AutoSize = true;
						label1.Location = new Point(341, 46);
						label1.Name = "label1";
						label1.Size = new Size(50, 20);
						label1.TabIndex = 0;
						label1.Text = "label1";
						// 
						// listBox1
						// 
						listBox1.FormattingEnabled = true;
						listBox1.Location = new Point(296, 120);
						listBox1.Name = "listBox1";
						listBox1.Size = new Size(150, 104);
						listBox1.TabIndex = 1;
						// 
						// button1
						// 
						button1.Location = new Point(351, 294);
						button1.Name = "button1";
						button1.Size = new Size(94, 29);
						button1.TabIndex = 2;
						button1.Text = "button1";
						button1.UseVisualStyleBackColor = true;
						// 
						// TrainingForm
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						ClientSize = new Size(800, 450);
						Controls.Add(button1);
						Controls.Add(listBox1);
						Controls.Add(label1);
						Name = "TrainingForm";
						Text = "TrainingForm";
						ResumeLayout(false);
						PerformLayout();
				}

				#endregion

				private Label label1;
				private ListBox listBox1;
				private Button button1;
		}
}