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

        private void EmailDetailForm_Load(object sender, EventArgs e)
        {
            lbSubject.Text = message.Subject.ToString();
            lbFrom.Text = message.From.ToString();
            lbTo.Text = message.To.ToString();
            rtbMessage.Text = message.TextBody.ToString();
        }
    }
}
