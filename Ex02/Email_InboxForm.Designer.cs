﻿namespace Ex02
{
    partial class frmInbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsEmail=new ListView();
            colEmail=new ColumnHeader();
            colFrom=new ColumnHeader();
            colDate=new ColumnHeader();
            label2=new Label();
            label1=new Label();
            tbPassword=new TextBox();
            tbEmail=new TextBox();
            btnLogin=new Button();
            SuspendLayout();
            // 
            // lsEmail
            // 
            lsEmail.Columns.AddRange(new ColumnHeader[] { colEmail, colFrom, colDate });
            lsEmail.Location=new Point(12, 104);
            lsEmail.Name="lsEmail";
            lsEmail.Size=new Size(776, 334);
            lsEmail.TabIndex=0;
            lsEmail.UseCompatibleStateImageBehavior=false;
            lsEmail.View=View.Details;
            // 
            // colEmail
            // 
            colEmail.Text="Email";
            colEmail.Width=275;
            // 
            // colFrom
            // 
            colFrom.Text="From";
            colFrom.Width=226;
            // 
            // colDate
            // 
            colDate.Text="Date";
            colDate.Width=275;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(14, 63);
            label2.Name="label2";
            label2.Size=new Size(57, 15);
            label2.TabIndex=9;
            label2.Text="Password";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(14, 18);
            label1.Name="label1";
            label1.Size=new Size(36, 15);
            label1.TabIndex=8;
            label1.Text="Email";
            // 
            // tbPassword
            // 
            tbPassword.Location=new Point(86, 60);
            tbPassword.Name="tbPassword";
            tbPassword.Size=new Size(245, 23);
            tbPassword.TabIndex=7;
            // 
            // tbEmail
            // 
            tbEmail.Location=new Point(86, 15);
            tbEmail.Name="tbEmail";
            tbEmail.Size=new Size(245, 23);
            tbEmail.TabIndex=6;
            // 
            // btnLogin
            // 
            btnLogin.Location=new Point(681, 12);
            btnLogin.Name="btnLogin";
            btnLogin.Size=new Size(107, 29);
            btnLogin.TabIndex=5;
            btnLogin.Text="LOGIN";
            btnLogin.UseVisualStyleBackColor=true;
            btnLogin.Click+=btnLogin_Click;
            // 
            // frmInbox
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(btnLogin);
            Controls.Add(lsEmail);
            Name="frmInbox";
            Text="Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsEmail;
        private Label label2;
        private Label label1;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Button btnLogin;
        private ColumnHeader colEmail;
        private ColumnHeader colFrom;
        private ColumnHeader colDate;
    }
}