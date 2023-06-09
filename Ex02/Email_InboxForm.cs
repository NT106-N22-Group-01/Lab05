using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;

namespace Ex02
{
    public partial class frmInbox : Form
    {
        public frmInbox()
        {
            InitializeComponent();
        }

        ImapClient client = new ImapClient();
        private int email_limit = 10;
        private int email_count = 0;
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

        private async Task<bool> connect_to_IMAPserverAsync(string acc, string pass)
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
        }

        private async Task loadEmailAsync()
        {
            lsmess = new List<MimeMessage>();
            for (int i = 0; i < email_limit; i++)
            {
                var mess = await client.Inbox.GetMessageAsync(id[i]);
                lsmess.Add(mess);
            }

            foreach (var mess in lsmess)
            {
                var item = new ListViewItem(mess.Subject.ToString());
                item.SubItems.Add(mess.From.ToString());
                item.SubItems.Add(mess.Date.LocalDateTime.ToString());
                item.Tag = mess;
                lsEmail.Items.Add(item);
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (check_For_Empty_Txtbox())
                return;

            btnLogin.Visible = false;

            try
            {
                if (!await connect_to_IMAPserverAsync(tbEmail.Text.Trim(), tbPassword.Text.Trim()))
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

            await extractEmailAsync();
            await loadEmailAsync();
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
    }
}
