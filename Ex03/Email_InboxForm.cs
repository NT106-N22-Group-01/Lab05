using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;

namespace Ex03
{
	public partial class frmInbox : Form
	{
		public frmInbox()
		{
			InitializeComponent();
		}

		ImapClient client = new ImapClient();
		private int emailLimit = 10;
		private int emailOffset = 0;
		private List<MimeMessage> lsmess;
		private List<UniqueId> id;

		private bool check_For_Empty_Txtbox()
		{
			if (String.IsNullOrWhiteSpace(tbEmail.Text))
			{
				MessageBox.Show("Email field is required.");
				return true;
			}

			if (String.IsNullOrEmpty(tbPassword.Text))
			{
				MessageBox.Show("Password field is required.");
				return true;
			}

			return false;
		}

		private async Task<bool> connect_to_POP3serverAsync(string acc, string pass)
		{
			try
			{
				if (!client.IsConnected)
					await client.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

				await client.AuthenticateAsync(acc, pass);

				if (!client.IsAuthenticated)
					return false;
			}
			catch (Exception ex)
			{
				throw;
			}

			return true;
		}

		private async Task extractEmailAsync()
		{
			var inbox = client.Inbox;
			await inbox.OpenAsync(FolderAccess.ReadOnly);
			var search = SearchQuery.All;
			id = inbox.Search(search).ToList();
			id.Reverse();
			lbMess_count.Text = id.Count.ToString();
		}

		private async Task loadEmailAsync(int limit)
		{
			if (!client.IsConnected)
			{
				MessageBox.Show("Chưa kết nối đến server", "ImapClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (id.Count == 0)
			{
				return;
			}

			this.Enabled = false;

			try
			{
				var startIndex = emailOffset;
				var endIndex = emailOffset + limit - 1;
				endIndex = Math.Min(endIndex, id.Count - 1);

				lsmess = new List<MimeMessage>();
				foreach (var uid in id.Skip(startIndex).Take(endIndex - startIndex + 1))
				{
					var message = await client.Inbox.GetMessageAsync(uid);
					lsmess.Add(message);
				}
			}
			finally
			{
				this.Enabled = true;
				this.Focus();
			}
			emailOffset += limit;
			PopulateListView();
		}

		private void PopulateListView()
		{
			lsEmail.BeginUpdate();

			foreach (var mess in lsmess)
			{
				var item = new ListViewItem(mess.Subject.ToString());
				item.SubItems.Add(mess.From.ToString());
				item.SubItems.Add(mess.Date.LocalDateTime.ToString());
				item.Tag = mess;
				lsEmail.Items.Add(item);
			}
			lsEmail.EndUpdate();
		}

		private async void buttonLoadMore_Click_1(object sender, EventArgs e)
		{
			await loadEmailAsync(emailLimit);
		}

		private async void btnLogin_Click(object sender, EventArgs e)
		{
			if (check_For_Empty_Txtbox())
				return;

			try
			{
				if (!await connect_to_POP3serverAsync(tbEmail.Text.Trim(), tbPassword.Text.Trim()))
				{
					MessageBox.Show("Lỗi kết nối");
					btnLogin.Visible = true;
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				btnLogin.Visible = true;
				return;
			}

			btnLogin.Visible = false;
			btnLogin.Enabled = false;
			btnRefresh.Visible = true;
			btnRefresh.Enabled = true;
			btnLogout.Visible = true;
			btnLogout.Enabled = true;
			buttonLoadMore.Visible = true;
			buttonLoadMore.Enabled = true;

			await extractEmailAsync();
			await loadEmailAsync(emailLimit);
		}

		private void lsEmail_DoubleClick(object sender, EventArgs e)
		{
			if (lsEmail.SelectedItems.Count > 0)
			{
				ListViewItem select = lsEmail.SelectedItems[0];
				MimeMessage mess = select.Tag as MimeMessage;

				if (mess != null)
				{
					using (var frmDetail = new EmailDetailForm(mess))
					{
						frmDetail.ShowDialog();
					}
				}
			}
		}

		private async void btnRefresh_Click(object sender, EventArgs e)
		{
			lbMess_count.Text = String.Empty;
			lsEmail.Items.Clear();
			id.Clear();
			btnRefresh.Enabled = false;
			await extractEmailAsync();
			await loadEmailAsync(emailLimit);
			btnRefresh.Enabled = true;
		}

		private async void btnLogout_Click(object sender, EventArgs e)
		{
			await client.DisconnectAsync(true);
			lsEmail.Items.Clear();
			id.Clear();
			btnLogout.Enabled = false;
			btnLogout.Visible = false;
			btnRefresh.Enabled = false;
			btnRefresh.Visible = false;
			btnLogin.Enabled = true;
			btnLogin.Visible = true;
			buttonLoadMore.Visible = false;
			buttonLoadMore.Enabled = false;
			lbMess_count.Text = String.Empty;
			tbEmail.Clear();
			tbPassword.Clear();
		}
	}
}
