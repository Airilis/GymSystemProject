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
						lblSummary = new Label();
						btnConfirm = new Button();
						label1 = new Label();
						SuspendLayout();
						// 
						// lblSummary
						// 
						lblSummary.AutoSize = true;
						lblSummary.Location = new Point(379, 126);
						lblSummary.Name = "lblSummary";
						lblSummary.Size = new Size(50, 20);
						lblSummary.TabIndex = 1;
						lblSummary.Text = "label2";
						// 
						// btnConfirm
						// 
						btnConfirm.Location = new Point(271, 230);
						btnConfirm.Name = "btnConfirm";
						btnConfirm.Size = new Size(94, 29);
						btnConfirm.TabIndex = 2;
						btnConfirm.Text = "Confirm";
						btnConfirm.UseVisualStyleBackColor = true;
						btnConfirm.Click += btnConfirm_Click;
						// 
						// label1
						// 
						label1.AutoSize = true;
						label1.Location = new Point(333, 55);
						label1.Name = "label1";
						label1.Size = new Size(142, 20);
						label1.TabIndex = 3;
						label1.Text = "Confirm your choice";
						// 
						// ConfirmForm
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						ClientSize = new Size(800, 450);
						Controls.Add(label1);
						Controls.Add(btnConfirm);
						Controls.Add(lblSummary);
						Name = "ConfirmForm";
						Text = "ConfirmForm";
						ResumeLayout(false);
						PerformLayout();
				}

				#endregion
				private Label lblSummary;
				private Button btnConfirm;
				private Label label1;
		}
}