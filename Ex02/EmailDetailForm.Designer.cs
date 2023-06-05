namespace Ex02
{
    partial class EmailDetailForm
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
            lbSubject=new Label();
            label2=new Label();
            label3=new Label();
            lbFrom=new Label();
            lbTo=new Label();
            rtbMessage=new RichTextBox();
            SuspendLayout();
            // 
            // lbSubject
            // 
            lbSubject.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSubject.Location=new Point(12, 18);
            lbSubject.Name="lbSubject";
            lbSubject.Size=new Size(663, 30);
            lbSubject.TabIndex=1;
            lbSubject.Text="Subject";
            // 
            // label2
            // 
            label2.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(12, 68);
            label2.Name="label2";
            label2.Size=new Size(49, 15);
            label2.TabIndex=2;
            label2.Text="From:";
            label2.TextAlign=ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(12, 103);
            label3.Name="label3";
            label3.Size=new Size(49, 15);
            label3.TabIndex=3;
            label3.Text="To:";
            label3.TextAlign=ContentAlignment.MiddleRight;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize=true;
            lbFrom.Location=new Point(81, 69);
            lbFrom.Name="lbFrom";
            lbFrom.Size=new Size(33, 15);
            lbFrom.TabIndex=4;
            lbFrom.Text="from";
            // 
            // lbTo
            // 
            lbTo.AutoSize=true;
            lbTo.Location=new Point(81, 104);
            lbTo.Name="lbTo";
            lbTo.Size=new Size(18, 15);
            lbTo.TabIndex=5;
            lbTo.Text="to";
            // 
            // rtbMessage
            // 
            rtbMessage.Location=new Point(12, 140);
            rtbMessage.Name="rtbMessage";
            rtbMessage.Size=new Size(663, 298);
            rtbMessage.TabIndex=6;
            rtbMessage.Text="";
            // 
            // EmailDetailForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(687, 450);
            Controls.Add(rtbMessage);
            Controls.Add(lbTo);
            Controls.Add(lbFrom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbSubject);
            Name="EmailDetailForm";
            Text="EmailDetailForm";
            Load+=EmailDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbSubject;
        private Label label2;
        private Label label3;
        private Label lbFrom;
        private Label lbTo;
        private RichTextBox rtbMessage;
    }
}