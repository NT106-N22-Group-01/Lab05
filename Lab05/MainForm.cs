namespace Lab05
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.FormClosed += (sender, e) => Application.Exit();
		}

		private void buttonEx01_Click(object sender, EventArgs e)
		{
			/*			this.Hide();
						var Ex01 = new Ex01.Ex01();
						Ex01.FormClosed += ShowMainForm;
						Ex01.Show();*/
		}

		private void buttonEx2_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex02 = new Ex02.frmInbox();
			Ex02.FormClosed += ShowMainForm;
			Ex02.Show();
		}

		private void buttonEx3_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex03 = new Ex03.frmInbox();
			Ex03.FormClosed += ShowMainForm;
			Ex03.Show();
		}

		private void buttonEx4_Click(object sender, EventArgs e)
		{
			this.Hide();
			var Ex04 = new Ex04.MailClient();
			Ex04.FormClosed += ShowMainForm;
			Ex04.Show();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void ShowMainForm(object sender, EventArgs e)
		{
			var MainForm = new MainForm();
			MainForm.Show();
		}
	}
}