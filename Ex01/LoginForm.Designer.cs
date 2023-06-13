namespace Ex01
{
	partial class LoginForm
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
			groupBoxLogin = new GroupBox();
			buttonLogin = new Button();
			labePassword = new Label();
			textBoxPassword = new TextBox();
			labelAccount = new Label();
			textBoxAccount = new TextBox();
			groupBoxLogin.SuspendLayout();
			SuspendLayout();
			// 
			// groupBoxLogin
			// 
			groupBoxLogin.Controls.Add(buttonLogin);
			groupBoxLogin.Controls.Add(labePassword);
			groupBoxLogin.Controls.Add(textBoxPassword);
			groupBoxLogin.Controls.Add(labelAccount);
			groupBoxLogin.Controls.Add(textBoxAccount);
			groupBoxLogin.Font = new Font("Open Sans", 11F, FontStyle.Bold, GraphicsUnit.Point);
			groupBoxLogin.Location = new Point(12, 12);
			groupBoxLogin.Name = "groupBoxLogin";
			groupBoxLogin.Size = new Size(554, 208);
			groupBoxLogin.TabIndex = 1;
			groupBoxLogin.TabStop = false;
			groupBoxLogin.Text = "Đăng nhập";
			// 
			// buttonLogin
			// 
			buttonLogin.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			buttonLogin.Location = new Point(197, 147);
			buttonLogin.Name = "buttonLogin";
			buttonLogin.Size = new Size(160, 42);
			buttonLogin.TabIndex = 4;
			buttonLogin.Text = "Đăng nhập";
			buttonLogin.UseVisualStyleBackColor = true;
			buttonLogin.Click += buttonLogin_Click;
			// 
			// labePassword
			// 
			labePassword.AutoSize = true;
			labePassword.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labePassword.Location = new Point(21, 95);
			labePassword.Name = "labePassword";
			labePassword.Size = new Size(111, 30);
			labePassword.TabIndex = 3;
			labePassword.Text = "Mật khẩu";
			// 
			// textBoxPassword
			// 
			textBoxPassword.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxPassword.Location = new Point(146, 92);
			textBoxPassword.Name = "textBoxPassword";
			textBoxPassword.PasswordChar = '*';
			textBoxPassword.Size = new Size(368, 37);
			textBoxPassword.TabIndex = 2;
			// 
			// labelAccount
			// 
			labelAccount.AutoSize = true;
			labelAccount.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelAccount.Location = new Point(21, 41);
			labelAccount.Name = "labelAccount";
			labelAccount.Size = new Size(114, 30);
			labelAccount.TabIndex = 1;
			labelAccount.Text = "Tài khoản";
			// 
			// textBoxAccount
			// 
			textBoxAccount.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxAccount.Location = new Point(146, 38);
			textBoxAccount.Name = "textBoxAccount";
			textBoxAccount.Size = new Size(368, 37);
			textBoxAccount.TabIndex = 1;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(575, 235);
			Controls.Add(groupBoxLogin);
			Name = "LoginForm";
			Text = "LoginForm";
			groupBoxLogin.ResumeLayout(false);
			groupBoxLogin.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBoxLogin;
		private Button buttonLogin;
		private Label labePassword;
		private TextBox textBoxPassword;
		private Label labelAccount;
		private TextBox textBoxAccount;
	}
}