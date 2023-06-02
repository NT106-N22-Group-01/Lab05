namespace Ex04
{
	partial class MailClient
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
			groupBoxLogin = new GroupBox();
			buttonLogout = new Button();
			buttonSendMail = new Button();
			buttonRefresh = new Button();
			buttonLogin = new Button();
			labePassword = new Label();
			textBoxPassword = new TextBox();
			labelAccount = new Label();
			textBoxAccount = new TextBox();
			groupBoxSetting = new GroupBox();
			numericUpDownSMTPPort = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			textBoxSMTP = new TextBox();
			numericUpDownIMAPPort = new NumericUpDown();
			labelIMAPPort = new Label();
			labelIMAP = new Label();
			textBoxIMAP = new TextBox();
			listViewEmails = new ListView();
			ID = new ColumnHeader();
			From = new ColumnHeader();
			Subject = new ColumnHeader();
			DateTime = new ColumnHeader();
			buttonLoadMore = new Button();
			labelTotal = new Label();
			labelTotalNum = new Label();
			groupBoxLogin.SuspendLayout();
			groupBoxSetting.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownSMTPPort).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownIMAPPort).BeginInit();
			SuspendLayout();
			// 
			// groupBoxLogin
			// 
			groupBoxLogin.Controls.Add(buttonLogout);
			groupBoxLogin.Controls.Add(buttonSendMail);
			groupBoxLogin.Controls.Add(buttonRefresh);
			groupBoxLogin.Controls.Add(buttonLogin);
			groupBoxLogin.Controls.Add(labePassword);
			groupBoxLogin.Controls.Add(textBoxPassword);
			groupBoxLogin.Controls.Add(labelAccount);
			groupBoxLogin.Controls.Add(textBoxAccount);
			groupBoxLogin.Font = new Font("Open Sans", 11F, FontStyle.Bold, GraphicsUnit.Point);
			groupBoxLogin.Location = new Point(12, 12);
			groupBoxLogin.Name = "groupBoxLogin";
			groupBoxLogin.Size = new Size(540, 205);
			groupBoxLogin.TabIndex = 0;
			groupBoxLogin.TabStop = false;
			groupBoxLogin.Text = "Đăng nhập";
			// 
			// buttonLogout
			// 
			buttonLogout.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			buttonLogout.Location = new Point(354, 146);
			buttonLogout.Name = "buttonLogout";
			buttonLogout.Size = new Size(160, 42);
			buttonLogout.TabIndex = 7;
			buttonLogout.Text = "Đăng xuất";
			buttonLogout.UseVisualStyleBackColor = true;
			buttonLogout.Visible = false;
			buttonLogout.Click += buttonLogout_Click;
			// 
			// buttonSendMail
			// 
			buttonSendMail.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSendMail.Location = new Point(21, 146);
			buttonSendMail.Name = "buttonSendMail";
			buttonSendMail.Size = new Size(160, 42);
			buttonSendMail.TabIndex = 6;
			buttonSendMail.Text = "Gửi Mail";
			buttonSendMail.UseVisualStyleBackColor = true;
			buttonSendMail.Visible = false;
			// 
			// buttonRefresh
			// 
			buttonRefresh.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			buttonRefresh.Location = new Point(188, 146);
			buttonRefresh.Name = "buttonRefresh";
			buttonRefresh.Size = new Size(160, 42);
			buttonRefresh.TabIndex = 5;
			buttonRefresh.Text = "Refresh";
			buttonRefresh.UseVisualStyleBackColor = true;
			buttonRefresh.Visible = false;
			buttonRefresh.Click += buttonRefresh_Click;
			// 
			// buttonLogin
			// 
			buttonLogin.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			buttonLogin.Location = new Point(354, 146);
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
			// groupBoxSetting
			// 
			groupBoxSetting.Controls.Add(numericUpDownSMTPPort);
			groupBoxSetting.Controls.Add(label1);
			groupBoxSetting.Controls.Add(label2);
			groupBoxSetting.Controls.Add(textBoxSMTP);
			groupBoxSetting.Controls.Add(numericUpDownIMAPPort);
			groupBoxSetting.Controls.Add(labelIMAPPort);
			groupBoxSetting.Controls.Add(labelIMAP);
			groupBoxSetting.Controls.Add(textBoxIMAP);
			groupBoxSetting.Font = new Font("Open Sans", 11F, FontStyle.Bold, GraphicsUnit.Point);
			groupBoxSetting.Location = new Point(581, 12);
			groupBoxSetting.Name = "groupBoxSetting";
			groupBoxSetting.Size = new Size(887, 149);
			groupBoxSetting.TabIndex = 1;
			groupBoxSetting.TabStop = false;
			groupBoxSetting.Text = "Cài đặt";
			// 
			// numericUpDownSMTPPort
			// 
			numericUpDownSMTPPort.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			numericUpDownSMTPPort.Location = new Point(530, 96);
			numericUpDownSMTPPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
			numericUpDownSMTPPort.Name = "numericUpDownSMTPPort";
			numericUpDownSMTPPort.Size = new Size(342, 37);
			numericUpDownSMTPPort.TabIndex = 6;
			numericUpDownSMTPPort.Value = new decimal(new int[] { 465, 0, 0, 0 });
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(453, 95);
			label1.Name = "label1";
			label1.Size = new Size(56, 30);
			label1.TabIndex = 12;
			label1.Text = "Port";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(453, 41);
			label2.Name = "label2";
			label2.Size = new Size(70, 30);
			label2.TabIndex = 11;
			label2.Text = "SMTP";
			// 
			// textBoxSMTP
			// 
			textBoxSMTP.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSMTP.Location = new Point(530, 38);
			textBoxSMTP.Name = "textBoxSMTP";
			textBoxSMTP.Size = new Size(342, 37);
			textBoxSMTP.TabIndex = 5;
			textBoxSMTP.Text = "smtp.gmail.com";
			// 
			// numericUpDownIMAPPort
			// 
			numericUpDownIMAPPort.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			numericUpDownIMAPPort.Location = new Point(87, 96);
			numericUpDownIMAPPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
			numericUpDownIMAPPort.Name = "numericUpDownIMAPPort";
			numericUpDownIMAPPort.Size = new Size(335, 37);
			numericUpDownIMAPPort.TabIndex = 4;
			numericUpDownIMAPPort.Value = new decimal(new int[] { 993, 0, 0, 0 });
			// 
			// labelIMAPPort
			// 
			labelIMAPPort.AutoSize = true;
			labelIMAPPort.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelIMAPPort.Location = new Point(15, 99);
			labelIMAPPort.Name = "labelIMAPPort";
			labelIMAPPort.Size = new Size(56, 30);
			labelIMAPPort.TabIndex = 8;
			labelIMAPPort.Text = "Port";
			// 
			// labelIMAP
			// 
			labelIMAP.AutoSize = true;
			labelIMAP.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelIMAP.Location = new Point(15, 45);
			labelIMAP.Name = "labelIMAP";
			labelIMAP.Size = new Size(66, 30);
			labelIMAP.TabIndex = 6;
			labelIMAP.Text = "IMAP";
			// 
			// textBoxIMAP
			// 
			textBoxIMAP.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxIMAP.Location = new Point(87, 38);
			textBoxIMAP.Name = "textBoxIMAP";
			textBoxIMAP.Size = new Size(335, 37);
			textBoxIMAP.TabIndex = 3;
			textBoxIMAP.Text = "imap.gmail.com";
			// 
			// listViewEmails
			// 
			listViewEmails.Columns.AddRange(new ColumnHeader[] { ID, From, Subject, DateTime });
			listViewEmails.FullRowSelect = true;
			listViewEmails.ImeMode = ImeMode.NoControl;
			listViewEmails.Location = new Point(12, 237);
			listViewEmails.MultiSelect = false;
			listViewEmails.Name = "listViewEmails";
			listViewEmails.Size = new Size(1456, 744);
			listViewEmails.TabIndex = 2;
			listViewEmails.UseCompatibleStateImageBehavior = false;
			listViewEmails.View = View.Details;
			listViewEmails.DoubleClick += listViewEmails_DoubleClick;
			// 
			// ID
			// 
			ID.Text = "#";
			// 
			// From
			// 
			From.Text = "From";
			From.Width = 500;
			// 
			// Subject
			// 
			Subject.Text = "Subject";
			Subject.Width = 680;
			// 
			// DateTime
			// 
			DateTime.Text = "DateTime";
			DateTime.Width = 212;
			// 
			// buttonLoadMore
			// 
			buttonLoadMore.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			buttonLoadMore.Location = new Point(1308, 175);
			buttonLoadMore.Name = "buttonLoadMore";
			buttonLoadMore.Size = new Size(160, 42);
			buttonLoadMore.TabIndex = 8;
			buttonLoadMore.Text = "Load Thêm";
			buttonLoadMore.UseVisualStyleBackColor = true;
			buttonLoadMore.Visible = false;
			buttonLoadMore.Click += buttonLoadMore_Click;
			// 
			// labelTotal
			// 
			labelTotal.AutoSize = true;
			labelTotal.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelTotal.Location = new Point(581, 181);
			labelTotal.Name = "labelTotal";
			labelTotal.Size = new Size(64, 30);
			labelTotal.TabIndex = 9;
			labelTotal.Text = "Total";
			// 
			// labelTotalNum
			// 
			labelTotalNum.AutoSize = true;
			labelTotalNum.Font = new Font("Open Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelTotalNum.Location = new Point(651, 181);
			labelTotalNum.Name = "labelTotalNum";
			labelTotalNum.Size = new Size(0, 30);
			labelTotalNum.TabIndex = 10;
			// 
			// MailClient
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1491, 1007);
			Controls.Add(labelTotalNum);
			Controls.Add(labelTotal);
			Controls.Add(buttonLoadMore);
			Controls.Add(listViewEmails);
			Controls.Add(groupBoxSetting);
			Controls.Add(groupBoxLogin);
			Name = "MailClient";
			Text = "Mail Client";
			groupBoxLogin.ResumeLayout(false);
			groupBoxLogin.PerformLayout();
			groupBoxSetting.ResumeLayout(false);
			groupBoxSetting.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownSMTPPort).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownIMAPPort).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBoxLogin;
		private Button buttonLogin;
		private Label labePassword;
		private TextBox textBoxPassword;
		private Label labelAccount;
		private TextBox textBoxAccount;
		private GroupBox groupBoxSetting;
		private Label labelIMAPPort;
		private Label labelIMAP;
		private TextBox textBoxIMAP;
		private NumericUpDown numericUpDownIMAPPort;
		private NumericUpDown numericUpDownSMTPPort;
		private Label label1;
		private Label label2;
		private TextBox textBoxSMTP;
		private ListView listViewEmails;
		private ColumnHeader ID;
		private ColumnHeader From;
		private ColumnHeader Subject;
		private ColumnHeader DateTime;
		private Button buttonSendMail;
		private Button buttonRefresh;
		private Button buttonLogout;
		private Button buttonLoadMore;
		private Label labelTotal;
		private Label labelTotalNum;
	}
}