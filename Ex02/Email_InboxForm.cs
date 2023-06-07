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

        private int email_limit = 10;
        private int email_count = 0;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (check_For_Empty_Txtbox())
                return;

            try
            {
                email_count = 0;
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                client.Authenticate(tbEmail.Text.Trim(), tbPassword.Text.Trim());
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);


                for (int i = 0; i < email_limit; i++)
                {
                    var message = inbox.GetMessage(i);
                    var item = new ListViewItem(message.Subject.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    email_count++;
                }

                lbMess_count.Text = email_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
