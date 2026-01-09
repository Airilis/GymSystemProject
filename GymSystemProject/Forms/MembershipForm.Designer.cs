namespace GymSystemProject.Forms
{
		partial class MembershipForm
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
						currentMembership = new Label();
						dateTimePicker1 = new DateTimePicker();
						btnCkeckMembership = new Button();
						chkPay = new CheckBox();
						SuspendLayout();
						// 
						// currentMembership
						// 
						currentMembership.AutoSize = true;
						currentMembership.Location = new Point(302, 47);
						currentMembership.Name = "currentMembership";
						currentMembership.Size = new Size(175, 20);
						currentMembership.TabIndex = 0;
						currentMembership.Text = "Your current membership";
						// 
						// dateTimePicker1
						// 
						dateTimePicker1.Location = new Point(278, 70);
						dateTimePicker1.Name = "dateTimePicker1";
						dateTimePicker1.Size = new Size(250, 27);
						dateTimePicker1.TabIndex = 1;
						// 
						// btnCkeckMembership
						// 
						btnCkeckMembership.Location = new Point(339, 157);
						btnCkeckMembership.Name = "btnCkeckMembership";
						btnCkeckMembership.Size = new Size(94, 29);
						btnCkeckMembership.TabIndex = 2;
						btnCkeckMembership.Text = "Check";
						btnCkeckMembership.UseVisualStyleBackColor = true;
						// 
						// chkPay
						// 
						chkPay.AutoSize = true;
						chkPay.Location = new Point(353, 272);
						chkPay.Name = "chkPay";
						chkPay.Size = new Size(55, 24);
						chkPay.TabIndex = 3;
						chkPay.Text = "pay";
						chkPay.UseVisualStyleBackColor = true;
						// 
						// MembershipForm
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						ClientSize = new Size(800, 450);
						Controls.Add(chkPay);
						Controls.Add(btnCkeckMembership);
						Controls.Add(dateTimePicker1);
						Controls.Add(currentMembership);
						Name = "MembershipForm";
						Text = "MembershipForm";
						ResumeLayout(false);
						PerformLayout();
				}

				#endregion

				private Label currentMembership;
				private DateTimePicker dateTimePicker1;
				private Button btnCkeckMembership;
				private CheckBox chkPay;
		}
}