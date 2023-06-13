using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Search;

namespace Ex03
{
    public partial class Ex03 : Form
    {
        public Ex03()
        {
            InitializeComponent();
            output.ReadOnly = true;
            pwdText.PasswordChar = '*';

        }
        bool isValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                if (!string.IsNullOrEmpty(trimmedEmail))
                {
                    var addr = new MailAddress(email);
                    return addr.Address == trimmedEmail;
                }
                else
                {
                    MessageBox.Show("Please fill out.", "Note:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        bool isValidProtocol(string protocol)
        {
            if (protocol == "IMAP" || protocol == "POP3")
            {
                return true;
            }
            MessageBox.Show("Wrong Protocol.", "Warning:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValidEmail(usrText.Text) && !string.IsNullOrEmpty(pwdText.Text) && isValidProtocol(protocolText.Text))
            {
                try
                {
                    output.Rows.Clear();
                    output.Columns.Clear();
                    output.Columns.Add("Subject", "Subject");
                    output.Columns.Add("From", "From");
                    output.Columns.Add("Date", "Date");

                    output.Columns["Subject"].ReadOnly = true;
                    output.Columns["From"].ReadOnly = true;
                    output.Columns["Date"].ReadOnly = true;
                    output.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    protocolText.Text = protocolText.Text.ToUpper().Trim();

                    int limit = 7;

                    if (protocolText.Text == "IMAP")
                    {
                        var client = new ImapClient();
                        client.Connect("imap.gmail.com", 993, true);
                        client.Authenticate(usrText.Text, pwdText.Text);

                        var inbox = client.Inbox;
                        inbox.Open(MailKit.FolderAccess.ReadOnly);

                        var query = SearchQuery.All;
                        var uids = inbox.Search(query).ToList();
                        uids.Reverse();


                        for (int i = 0; i < limit; i++)
                        {
                            var _imapmsg = inbox.GetMessage(i);
                            string subject = _imapmsg.Subject;
                            string senderMail = _imapmsg.From.ToString();
                            DateTime date = _imapmsg.Date.Date;
                            output.Rows.Add(subject, senderMail, date);
                        }
                    }

                    else
                    {
                        var client = new Pop3Client();
                        client.Connect("pop.gmail.com", 995, true);
                        client.Authenticate(usrText.Text, pwdText.Text);

                        for (int i = 0; i < limit; i++)
                        {
                            var _pop3msg = client.GetMessage(i);
                            var subject = _pop3msg.Subject;
                            var senderMail = _pop3msg.From.ToString();
                            DateTime date = _pop3msg.Date.DateTime;
                            output.Rows.Add(subject, senderMail, date);
                        }
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
