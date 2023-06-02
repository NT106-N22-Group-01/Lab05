using MimeKit;
using Markdig;

namespace Ex04
{
	public partial class EmailDetailForm : Form
	{
		private readonly MimeMessage email;

		public EmailDetailForm(MimeMessage email)
		{
			InitializeComponent();
			this.email = email;
		}

		private async void EmailDetailForm_Load(object sender, EventArgs e)
		{
			this.Text = email.Subject;
			labelFromText.Text = email.From.ToString();
			labelToText.Text = email.To.ToString();

			labelSubject.Text = email.Subject;

			await webView2.EnsureCoreWebView2Async();
			if (!string.IsNullOrEmpty(email.HtmlBody))
			{
				webView2.CoreWebView2.NavigateToString(email.HtmlBody);
			}
			else
			{
				var content = Markdown.ToHtml(email.TextBody);
				webView2.CoreWebView2.NavigateToString(content);
			}
		}
	}
}
