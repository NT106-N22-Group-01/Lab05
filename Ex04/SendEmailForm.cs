using MimeKit;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Ex04
{
	public partial class SendEmailForm : Form
	{
		private string _email;
		private SmtpClient _smtpClient;
		private string[] attachmentPaths;

		public SendEmailForm(string fromEmail, SmtpClient smtp)
		{
			InitializeComponent();
			_email = fromEmail;
			_smtpClient = smtp;
		}

		private bool TextBoxValidate()
		{
			if (string.IsNullOrWhiteSpace(textBoxTo.Text))
			{
				MessageBox.Show("Vui lòng nhập địa chỉ người nhận.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			try
			{
				var mailAddress = new MailAddress(textBoxTo.Text);
			}
			catch (FormatException)
			{
				MessageBox.Show("Vui lòng nhập đúng địa chỉ mail hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (string.IsNullOrWhiteSpace(textBoxSubject.Text))
			{
				MessageBox.Show("Vui lòng điền Subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (string.IsNullOrWhiteSpace(textBoxName.Text))
			{
				MessageBox.Show("Vui lòng điền Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void SendEmailForm_Load(object sender, EventArgs e)
		{
			textBoxFrom.Text = _email;
		}

		private async void buttonSend_Click(object sender, EventArgs e)
		{
			if (!_smtpClient.IsConnected)
			{
				MessageBox.Show("Chưa kết nối đến SMTP Server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try { 
				if (!TextBoxValidate())
					return;

				var from = textBoxFrom.Text;
				var to = textBoxTo.Text;
				var subject = textBoxSubject.Text;
				var name = textBoxName.Text;
				var body = richTextBoxBody.Text;
				var isHtml = checkBoxIsHTML.Checked;

				var message = new MimeMessage();
				message.From.Add(new MailboxAddress(name, from));
				message.To.Add(new MailboxAddress("", to));
				message.Subject = subject;

				var bodyBuilder = new BodyBuilder();
				if (isHtml)
				{
					bodyBuilder.HtmlBody = body;
				}
				else
				{
					bodyBuilder.TextBody = body;
				}

				if (attachmentPaths != null && attachmentPaths.Length > 0)
				{
					foreach (var path in attachmentPaths)
					{
						bodyBuilder.Attachments.Add(path);
					}
				}


				message.Body = bodyBuilder.ToMessageBody();
				await _smtpClient.SendAsync(message);

				textBoxTo.Text = string.Empty;
				textBoxSubject.Text = string.Empty;
				textBoxName.Text = string.Empty;
				richTextBoxBody.Text = string.Empty;
				textBoxAttachmentPaths.Text = string.Empty;
				attachmentPaths = null;
				MessageBox.Show("Gửi Email thành công.", "Thanh công", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch (Exception ex)
			{
				MessageBox.Show("Gửi Email không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Multiselect = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					attachmentPaths = openFileDialog.FileNames;
					textBoxAttachmentPaths.Text = string.Join(", ", attachmentPaths);
				}
			}
		}
	}
}
