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
						btnNext = new Button();
						chkBuyMembership = new CheckBox();
						btnBack = new Button();
						lblMembershipStatus = new Label();
						btnLogout = new Button();
						SuspendLayout();
						// 
						// currentMembership
						// 
						currentMembership.AutoSize = true;
						currentMembership.Location = new Point(281, 51);
						currentMembership.Name = "currentMembership";
						currentMembership.Size = new Size(175, 20);
						currentMembership.TabIndex = 0;
						currentMembership.Text = "Your current membership";
						// 
						// btnNext
						// 
						btnNext.Location = new Point(372, 252);
						btnNext.Name = "btnNext";
						btnNext.Size = new Size(94, 29);
						btnNext.TabIndex = 2;
						btnNext.Text = "Next";
						btnNext.UseVisualStyleBackColor = true;
						btnNext.Click += btnNext_Click;
						// 
						// chkBuyMembership
						// 
						chkBuyMembership.AutoSize = true;
						chkBuyMembership.Location = new Point(344, 168);
						chkBuyMembership.Name = "chkBuyMembership";
						chkBuyMembership.Size = new Size(55, 24);
						chkBuyMembership.TabIndex = 3;
						chkBuyMembership.Text = "pay";
						chkBuyMembership.UseVisualStyleBackColor = true;
						chkBuyMembership.CheckedChanged += chkBuyMembership_CheckedChanged;
						// 
						// btnBack
						// 
						btnBack.Location = new Point(272, 252);
						btnBack.Name = "btnBack";
						btnBack.Size = new Size(94, 29);
						btnBack.TabIndex = 4;
						btnBack.Text = "back";
						btnBack.UseVisualStyleBackColor = true;
						btnBack.Click += btnBack_Click;
						// 
						// lblMembershipStatus
						// 
						lblMembershipStatus.AutoSize = true;
						lblMembershipStatus.Location = new Point(349, 95);
						lblMembershipStatus.Name = "lblMembershipStatus";
						lblMembershipStatus.Size = new Size(50, 20);
						lblMembershipStatus.TabIndex = 5;
						lblMembershipStatus.Text = "label1";
						lblMembershipStatus.Click += lblMembershipStatus_Click;
						// 
						// btnLogout
						// 
						btnLogout.Location = new Point(694, 12);
						btnLogout.Name = "btnLogout";
						btnLogout.Size = new Size(94, 29);
						btnLogout.TabIndex = 6;
						btnLogout.Text = "log out";
						btnLogout.UseVisualStyleBackColor = true;
						btnLogout.Click += btnLogout_Click;
						// 
						// MembershipForm
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						ClientSize = new Size(800, 450);
						Controls.Add(btnLogout);
						Controls.Add(lblMembershipStatus);
						Controls.Add(btnBack);
						Controls.Add(chkBuyMembership);
						Controls.Add(btnNext);
						Controls.Add(currentMembership);
						Name = "MembershipForm";
						Text = "MembershipForm";
						FormClosed += MembershipForm_FormClosed;
						Shown += MembershipForm_Shown;
						ResumeLayout(false);
						PerformLayout();
				}

				#endregion

				private Label currentMembership;
				private Button btnNext;
				private CheckBox chkBuyMembership;
				private Button btnBack;
				private Label lblMembershipStatus;
				private Button btnLogout;
		}
}