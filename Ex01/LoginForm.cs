using MailKit.Net.Smtp;
using MailKit.Security;

namespace Ex01
{
	public partial class LoginForm : Form
	{
		private SmtpClient _smtpClient = new SmtpClient();

		public LoginForm()
		{
			InitializeComponent();
		}

		private async void buttonLogin_Click(object sender, EventArgs e)
		{
			if (!TextBoxValidate())
				return;
			var account = textBoxAccount.Text;
			var password = textBoxPassword.Text;
			var smtpServer = "smtp.gmail.com";
			var smtpPort = 465;
			try
			{
				if (!await ConnectToSMTPAsync(account, password, smtpServer, smtpPort))
				{
					MessageBox.Show("Không thể kết nối đến server. Kiểm tra lại tài khoản, mật khẩu và địa chỉ của SMTP",
							"SmtpClient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,
						"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var fmSendMail = new SendEmailForm(account, _smtpClient);
			fmSendMail.ShowDialog();
			this.Hide();
			this.Close();
		}

		private bool TextBoxValidate()
		{
			if (string.IsNullOrWhiteSpace(textBoxAccount.Text))
			{
				MessageBox.Show("Account is required.");
				return false;
			}

			if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
			{
				MessageBox.Show("Password is required.");
				return false;
			}
			return true;
		}

		private async Task<bool> ConnectToSMTPAsync(string account, string password, string smtpServer, int port)
		{
			try
			{
				if (!_smtpClient.IsConnected)
				{
					await _smtpClient.ConnectAsync(smtpServer, port, SecureSocketOptions.SslOnConnect);
				}
				await _smtpClient.AuthenticateAsync(account, password);

				if (_smtpClient.IsConnected == false)
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,
						"SmtpClient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
	}
}
