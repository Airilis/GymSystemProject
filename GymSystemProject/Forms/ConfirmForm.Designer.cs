namespace GymSystemProject.Forms
{
		partial class ConfirmForm
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
						label2 = new Label();
						button1 = new Button();
						SuspendLayout();
						// 
						// label1
						// 
						label1.AutoSize = true;
						label1.Location = new Point(379, 70);
						label1.Name = "label1";
						label1.Size = new Size(50, 20);
						label1.TabIndex = 0;
						label1.Text = "label1";
						// 
						// label2
						// 
						label2.AutoSize = true;
						label2.Location = new Point(386, 128);
						label2.Name = "label2";
						label2.Size = new Size(50, 20);
						label2.TabIndex = 1;
						label2.Text = "label2";
						// 
						// button1
						// 
						button1.Location = new Point(355, 227);
						button1.Name = "button1";
						button1.Size = new Size(94, 29);
						button1.TabIndex = 2;
						button1.Text = "button1";
						button1.UseVisualStyleBackColor = true;
						// 
						// ConfirmForm
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						ClientSize = new Size(800, 450);
						Controls.Add(button1);
						Controls.Add(label2);
						Controls.Add(label1);
						Name = "ConfirmForm";
						Text = "ConfirmForm";
						ResumeLayout(false);
						PerformLayout();
				}

				#endregion

				private Label label1;
				private Label label2;
				private Button button1;
		}
}