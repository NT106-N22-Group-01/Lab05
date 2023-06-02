using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MailKit.Security;
using MimeKit;

namespace Ex04
{
	public partial class MailClient : Form
	{
		ImapClient _imapClient = new ImapClient();
		SmtpClient _smtpClient = new SmtpClient();
		private int emailLimit = 10;
		private int emailOffset = 0;
		private int itemCount = 0;
		private List<MimeMessage> emails;
		private List<UniqueId> uids;

		public MailClient()
		{
			InitializeComponent();
		}

		private async void buttonLogin_Click(object sender, EventArgs e)
		{
			TextBoxValidate();
			var account = textBoxAccount.Text;
			var password = textBoxPassword.Text;
			var imapServer = textBoxIMAP.Text;
			var imapPort = Convert.ToInt32(numericUpDownIMAPPort.Value);
			var smtpServer = textBoxSMTP.Text;
			var smtpPort = Convert.ToInt32(numericUpDownSMTPPort.Value);
			buttonLogin.Visible = false;
			if (!await ConnectToIMAPAsync(account, password, imapServer, imapPort))
			{
				MessageBox.Show("Không thể kết nối đến server. Kiểm tra lại tài khoản, mật khẩu và địa chỉ của IMAP",
						"ImapClient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				buttonLogin.Visible = true;
				return;
			}
			if (!await ConnectToSMTPAsync(account, password, smtpServer, smtpPort))
			{
				MessageBox.Show("Không thể kết nối đến server. Kiểm tra lại tài khoản, mật khẩu và địa chỉ của SMTP",
						"SmtpClient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				buttonLogin.Visible = true;
				return;
			}
			ToggleControls();
			await SearchEmailsAsync();
			await LoadEmailsAsync(emailLimit);
		}

		private async void buttonLogout_Click(object sender, EventArgs e)
		{
			if (_imapClient.IsConnected)
			{
				await _imapClient.DisconnectAsync(true);
			}
			if (_smtpClient.IsConnected)
			{
				await _smtpClient.DisconnectAsync(true);
			}
			ToggleControls();
			ClearForm();
			buttonLogin.Visible = true;
		}

		private void ToggleControls()
		{
			groupBoxSetting.Enabled = !groupBoxSetting.Enabled;
			textBoxAccount.Enabled = !textBoxAccount.Enabled;
			textBoxPassword.Enabled = !textBoxPassword.Enabled;
			buttonLogout.Visible = !buttonLogout.Visible;
			buttonRefresh.Visible = !buttonRefresh.Visible;
			buttonSendMail.Visible = !buttonSendMail.Visible;
			buttonLoadMore.Visible = !buttonLoadMore.Visible;
		}

		private async Task<bool> ConnectToIMAPAsync(string account, string password, string imapServer, int port)
		{
			try
			{
				if (!_imapClient.IsConnected)
				{
					await _imapClient.ConnectAsync(imapServer, port, SecureSocketOptions.SslOnConnect);
				}
				await _imapClient.AuthenticateAsync(account, password);

				if (_imapClient.IsAuthenticated == false)
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,
						"ImapClient Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void TextBoxValidate()
		{
			if (!int.TryParse(numericUpDownIMAPPort.Text, out var imapPort))
			{
				MessageBox.Show("Invalid IMAP port number.");
				return;
			}

			if (!int.TryParse(numericUpDownSMTPPort.Text, out var smtpPort))
			{
				MessageBox.Show("Invalid SMTP port number.");
				return;
			}

			if (string.IsNullOrWhiteSpace(textBoxIMAP.Text))
			{
				MessageBox.Show("IMAP server URL is required.");
				return;
			}

			if (string.IsNullOrWhiteSpace(textBoxSMTP.Text))
			{
				MessageBox.Show("SMTP server URL is required.");
				return;
			}

			if (imapPort <= 0 || imapPort > 65535)
			{
				MessageBox.Show("Invalid IMAP port number.");
				return;
			}

			if (smtpPort <= 0 || smtpPort > 65535)
			{
				MessageBox.Show("Invalid SMTP port number.");
				return;
			}

			if (string.IsNullOrWhiteSpace(textBoxAccount.Text))
			{
				MessageBox.Show("Account is required.");
				return;
			}

			if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
			{
				MessageBox.Show("Password is required.");
				return;
			}
		}

		private async Task SearchEmailsAsync()
		{
			if (!_imapClient.IsConnected)
			{
				MessageBox.Show("Chưa kết nối đến server", "ImapClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var inbox = _imapClient.Inbox;
			await inbox.OpenAsync(FolderAccess.ReadOnly);

			var query = SearchQuery.All;
			uids = inbox.Search(query).ToList();
			uids.Reverse();
			labelTotalNum.Text = uids.Count().ToString();
		}

		private async Task LoadEmailsAsync(int limit)
		{
			if (!_imapClient.IsConnected)
			{
				MessageBox.Show("Chưa kết nối đến server", "ImapClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (uids.Count == 0)
			{
				return;
			}

			this.Enabled = false;
			var loadingMessageBox = CreateLoadingMessageBox();
			loadingMessageBox.Show();

			try
			{
				var startIndex = emailOffset;
				var endIndex = emailOffset + limit - 1;
				endIndex = Math.Min(endIndex, uids.Count - 1);

				emails = new List<MimeMessage>();
				foreach (var uid in uids.Skip(startIndex).Take(endIndex - startIndex + 1))
				{
					var message = await _imapClient.Inbox.GetMessageAsync(uid);
					emails.Add(message);
				}
			}
			finally
			{
				loadingMessageBox.Dispose();
				this.Enabled = true;
				this.Focus();
			}
			emailOffset += limit;
			PopulateListView();
		}

		private void PopulateListView()
		{
			listViewEmails.BeginUpdate();

			foreach (var email in emails)
			{
				var item = new ListViewItem((itemCount++).ToString());
				item.SubItems.Add(email.From.ToString());
				item.SubItems.Add(email.Subject);
				item.SubItems.Add(email.Date.LocalDateTime.ToString());

				item.Tag = email;

				listViewEmails.Items.Add(item);
			}
			listViewEmails.EndUpdate();
		}

		private async void buttonLoadMore_Click(object sender, EventArgs e)
		{
			await LoadEmailsAsync(emailLimit);
		}

		private async void buttonRefresh_Click(object sender, EventArgs e)
		{
			if (!_imapClient.IsConnected)
			{
				MessageBox.Show("Chưa kết nối đến server", "ImapClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			ClearForm();
			await SearchEmailsAsync();
			await LoadEmailsAsync(emailLimit);
		}

		private void ClearForm()
		{
			labelTotalNum.Text = String.Empty;
			listViewEmails.Items.Clear();
			emailOffset = 0;
			itemCount = 0;
			uids.Clear();
		}

		private Form CreateLoadingMessageBox()
		{
			var loadingMessageBox = new Form
			{
				TopMost = true,
				StartPosition = FormStartPosition.CenterScreen,
				FormBorderStyle = FormBorderStyle.None,
				Size = new Size(200, 100),
				ControlBox = false
			};
			var loadingLabel = new Label
			{
				Text = "Loading...",
				TextAlign = ContentAlignment.MiddleCenter,
				Dock = DockStyle.Fill
			};
			loadingMessageBox.Controls.Add(loadingLabel);
			return loadingMessageBox;
		}

		private void listViewEmails_DoubleClick(object sender, EventArgs e)
		{
			if (listViewEmails.SelectedItems.Count > 0)
			{
				ListViewItem selectedItem = listViewEmails.SelectedItems[0];
				MimeMessage email = selectedItem.Tag as MimeMessage;
				if (email != null)
				{
					using (var emailDetailForm = new EmailDetailForm(email))
					{
						emailDetailForm.ShowDialog();
					}
				}
			}
		}
	}
}