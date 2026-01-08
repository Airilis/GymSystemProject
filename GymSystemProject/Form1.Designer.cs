namespace GymSystemProject
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
				///  Required method for Designer support - do not modify
				///  the contents of this method with the code editor.
				/// </summary>
				private void InitializeComponent()
				{
						button_log_in = new Button();
						txtPassword = new TextBox();
						txtLogin = new TextBox();
						label1 = new Label();
						label2 = new Label();
						SuspendLayout();
						// 
						// button_log_in
						// 
						button_log_in.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
						button_log_in.Location = new Point(346, 334);
						button_log_in.Name = "button_log_in";
						button_log_in.Size = new Size(139, 40);
						button_log_in.TabIndex = 0;
						button_log_in.Text = "log in";
						button_log_in.UseVisualStyleBackColor = true;
						button_log_in.Click += btnLogin_Click;
						// 
						// txtPassword
						// 
						txtPassword.Cursor = Cursors.IBeam;
						txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
						txtPassword.Location = new Point(313, 249);
						txtPassword.Name = "txtPassword";
						txtPassword.PasswordChar = '*';
						txtPassword.PlaceholderText = "password";
						txtPassword.Size = new Size(204, 27);
						txtPassword.TabIndex = 1;
						txtPassword.TextChanged += txtPassword_TextChanged;
						// 
						// txtLogin
						// 
						txtLogin.Cursor = Cursors.IBeam;
						txtLogin.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
						txtLogin.Location = new Point(313, 185);
						txtLogin.Name = "txtLogin";
						txtLogin.PlaceholderText = "name";
						txtLogin.ShortcutsEnabled = false;
						txtLogin.Size = new Size(204, 27);
						txtLogin.TabIndex = 2;
						txtLogin.Tag = "";
						txtLogin.TextChanged += txtLogin_TextChanged;
						// 
						// label1
						// 
						label1.AutoSize = true;
						label1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
						label1.Location = new Point(346, 38);
						label1.Name = "label1";
						label1.Size = new Size(171, 41);
						label1.TabIndex = 3;
						label1.Text = "Hello :>";
						label1.TextAlign = ContentAlignment.TopCenter;
						// 
						// label2
						// 
						label2.AutoSize = true;
						label2.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold);
						label2.Location = new Point(175, 97);
						label2.Name = "label2";
						label2.Size = new Size(502, 41);
						label2.TabIndex = 4;
						label2.Text = "Before start please log in";
						// 
						// LoginPage
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						BackColor = SystemColors.Control;
						ClientSize = new Size(859, 490);
						Controls.Add(label2);
						Controls.Add(label1);
						Controls.Add(txtLogin);
						Controls.Add(txtPassword);
						Controls.Add(button_log_in);
						Name = "LoginPage";
						Text = "LoginPage";
						ResumeLayout(false);
						PerformLayout();
				}

				#endregion

				private Button button_log_in;
				private TextBox txtPassword;
				private TextBox txtLogin;
				private Label label1;
				private Label label2;
		}
}
