namespace Ex03
{
	partial class frmInbox
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
			lsEmail = new ListView();
			colEmail = new ColumnHeader();
			colFrom = new ColumnHeader();
			colDate = new ColumnHeader();
			label2 = new Label();
			label1 = new Label();
			tbPassword = new TextBox();
			tbEmail = new TextBox();
			btnLogin = new Button();
			label3 = new Label();
			lbMess_count = new Label();
			btnRefresh = new Button();
			btnLogout = new Button();
			buttonLoadMore = new Button();
			SuspendLayout();
			// 
			// lsEmail
			// 
			lsEmail.Columns.AddRange(new ColumnHeader[] { colEmail, colFrom, colDate });
			lsEmail.Location = new Point(17, 173);
			lsEmail.Margin = new Padding(4, 5, 4, 5);
			lsEmail.Name = "lsEmail";
			lsEmail.Size = new Size(1107, 554);
			lsEmail.TabIndex = 0;
			lsEmail.UseCompatibleStateImageBehavior = false;
			lsEmail.View = View.Details;
			lsEmail.DoubleClick += lsEmail_DoubleClick;
			// 
			// colEmail
			// 
			colEmail.Text = "Email";
			colEmail.Width = 275;
			// 
			// colFrom
			// 
			colFrom.Text = "From";
			colFrom.Width = 226;
			// 
			// colDate
			// 
			colDate.Text = "Date";
			colDate.Width = 275;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(20, 105);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(87, 25);
			label2.TabIndex = 9;
			label2.Text = "Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(20, 30);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(54, 25);
			label1.TabIndex = 8;
			label1.Text = "Email";
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(123, 100);
			tbPassword.Margin = new Padding(4, 5, 4, 5);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(348, 31);
			tbPassword.TabIndex = 7;
			// 
			// tbEmail
			// 
			tbEmail.Location = new Point(123, 25);
			tbEmail.Margin = new Padding(4, 5, 4, 5);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(348, 31);
			tbEmail.TabIndex = 6;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(973, 20);
			btnLogin.Margin = new Padding(4, 5, 4, 5);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(153, 48);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "LOGIN";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(491, 118);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(53, 25);
			label3.TabIndex = 10;
			label3.Text = "Total:";
			// 
			// lbMess_count
			// 
			lbMess_count.AutoSize = true;
			lbMess_count.Location = new Point(552, 118);
			lbMess_count.Margin = new Padding(4, 0, 4, 0);
			lbMess_count.Name = "lbMess_count";
			lbMess_count.Size = new Size(22, 25);
			lbMess_count.TabIndex = 11;
			lbMess_count.Text = "0";
			// 
			// btnRefresh
			// 
			btnRefresh.Enabled = false;
			btnRefresh.Location = new Point(799, 100);
			btnRefresh.Margin = new Padding(4, 5, 4, 5);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(153, 50);
			btnRefresh.TabIndex = 12;
			btnRefresh.Text = "REFRESH";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Visible = false;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnLogout
			// 
			btnLogout.Enabled = false;
			btnLogout.Location = new Point(973, 100);
			btnLogout.Margin = new Padding(4, 5, 4, 5);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(153, 48);
			btnLogout.TabIndex = 13;
			btnLogout.Text = "LOGOUT";
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Visible = false;
			btnLogout.Click += btnLogout_Click;
			// 
			// buttonLoadMore
			// 
			buttonLoadMore.Enabled = false;
			buttonLoadMore.Location = new Point(623, 100);
			buttonLoadMore.Margin = new Padding(4, 5, 4, 5);
			buttonLoadMore.Name = "buttonLoadMore";
			buttonLoadMore.Size = new Size(153, 50);
			buttonLoadMore.TabIndex = 14;
			buttonLoadMore.Text = "LOAD MORE";
			buttonLoadMore.UseVisualStyleBackColor = true;
			buttonLoadMore.Visible = false;
			buttonLoadMore.Click += buttonLoadMore_Click_1;
			// 
			// frmInbox
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1143, 750);
			Controls.Add(buttonLoadMore);
			Controls.Add(btnLogout);
			Controls.Add(btnRefresh);
			Controls.Add(lbMess_count);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbPassword);
			Controls.Add(tbEmail);
			Controls.Add(btnLogin);
			Controls.Add(lsEmail);
			Margin = new Padding(4, 5, 4, 5);
			Name = "frmInbox";
			Text = "Email";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView lsEmail;
		private Label label2;
		private Label label1;
		private TextBox tbPassword;
		private TextBox tbEmail;
		private Button btnLogin;
		private ColumnHeader colEmail;
		private ColumnHeader colFrom;
		private ColumnHeader colDate;
		private Label label3;
		private Label lbMess_count;
		private Button btnRefresh;
		private Button btnLogout;
		private Button buttonLoadMore;
	}
}