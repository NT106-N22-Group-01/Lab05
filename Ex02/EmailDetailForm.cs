using Markdig;
using MimeKit;

namespace Ex02
{
	public partial class EmailDetailForm : Form
	{
		public EmailDetailForm(MimeMessage message)
		{
			InitializeComponent();
			this.message = message;
		}

		private readonly MimeMessage message;

		private async void EmailDetailForm_Load(object sender, EventArgs e)
		{
			this.Text = message.Subject;
			lbFrom.Text = message.From.ToString();
			lbTo.Text = message.To.ToString();
			lbSubject.Text = message.Subject;

			await webView2.EnsureCoreWebView2Async();
			if (!string.IsNullOrEmpty(message.HtmlBody))
			{
				webView2.CoreWebView2.NavigateToString(message.HtmlBody);
			}
			else
			{
				var content = Markdown.ToHtml(message.TextBody);
				webView2.CoreWebView2.NavigateToString(content);
			}
		}
	}
}
