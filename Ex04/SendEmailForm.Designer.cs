namespace Ex04
{
	partial class SendEmailForm
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
			buttonSend = new Button();
			buttonBrowse = new Button();
			textBoxAttachmentPaths = new TextBox();
			labelAttachment = new Label();
			richTextBoxBody = new RichTextBox();
			checkBoxIsHTML = new CheckBox();
			labelBody = new Label();
			textBoxSubject = new TextBox();
			labelSubject = new Label();
			textBoxTo = new TextBox();
			labelTo = new Label();
			textBoxName = new TextBox();
			labelName = new Label();
			textBoxFrom = new TextBox();
			labelFrom = new Label();
			SuspendLayout();
			// 
			// buttonSend
			// 
			buttonSend.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSend.Location = new Point(347, 957);
			buttonSend.Name = "buttonSend";
			buttonSend.Size = new Size(119, 40);
			buttonSend.TabIndex = 29;
			buttonSend.Text = "Send";
			buttonSend.UseVisualStyleBackColor = true;
			buttonSend.Click += buttonSend_Click;
			// 
			// buttonBrowse
			// 
			buttonBrowse.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			buttonBrowse.Location = new Point(672, 908);
			buttonBrowse.Name = "buttonBrowse";
			buttonBrowse.Size = new Size(119, 40);
			buttonBrowse.TabIndex = 28;
			buttonBrowse.Text = "Browse";
			buttonBrowse.UseVisualStyleBackColor = true;
			buttonBrowse.Click += buttonBrowse_Click;
			// 
			// textBoxAttachmentPaths
			// 
			textBoxAttachmentPaths.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBoxAttachmentPaths.Location = new Point(176, 908);
			textBoxAttachmentPaths.Name = "textBoxAttachmentPaths";
			textBoxAttachmentPaths.Size = new Size(490, 40);
			textBoxAttachmentPaths.TabIndex = 27;
			// 
			// labelAttachment
			// 
			labelAttachment.AutoSize = true;
			labelAttachment.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelAttachment.Location = new Point(10, 912);
			labelAttachment.Name = "labelAttachment";
			labelAttachment.Size = new Size(149, 33);
			labelAttachment.TabIndex = 26;
			labelAttachment.Text = "Attachment:";
			// 
			// richTextBoxBody
			// 
			richTextBoxBody.Location = new Point(10, 333);
			richTextBoxBody.Name = "richTextBoxBody";
			richTextBoxBody.Size = new Size(781, 561);
			richTextBoxBody.TabIndex = 25;
			richTextBoxBody.Text = "";
			// 
			// checkBoxIsHTML
			// 
			checkBoxIsHTML.AutoSize = true;
			checkBoxIsHTML.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			checkBoxIsHTML.Location = new Point(119, 279);
			checkBoxIsHTML.Name = "checkBoxIsHTML";
			checkBoxIsHTML.Size = new Size(106, 37);
			checkBoxIsHTML.TabIndex = 24;
			checkBoxIsHTML.Text = "HTML";
			checkBoxIsHTML.UseVisualStyleBackColor = true;
			// 
			// labelBody
			// 
			labelBody.AutoSize = true;
			labelBody.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelBody.Location = new Point(10, 280);
			labelBody.Name = "labelBody";
			labelBody.Size = new Size(78, 33);
			labelBody.TabIndex = 23;
			labelBody.Text = "Body:";
			// 
			// textBoxSubject
			// 
			textBoxSubject.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSubject.Location = new Point(119, 221);
			textBoxSubject.Name = "textBoxSubject";
			textBoxSubject.Size = new Size(672, 40);
			textBoxSubject.TabIndex = 22;
			// 
			// labelSubject
			// 
			labelSubject.AutoSize = true;
			labelSubject.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelSubject.Location = new Point(10, 224);
			labelSubject.Name = "labelSubject";
			labelSubject.Size = new Size(102, 33);
			labelSubject.TabIndex = 21;
			labelSubject.Text = "Subject:";
			// 
			// textBoxTo
			// 
			textBoxTo.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxTo.Location = new Point(119, 155);
			textBoxTo.Name = "textBoxTo";
			textBoxTo.Size = new Size(672, 40);
			textBoxTo.TabIndex = 20;
			// 
			// labelTo
			// 
			labelTo.AutoSize = true;
			labelTo.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelTo.Location = new Point(10, 158);
			labelTo.Name = "labelTo";
			labelTo.Size = new Size(48, 33);
			labelTo.TabIndex = 19;
			labelTo.Text = "To:";
			// 
			// textBoxName
			// 
			textBoxName.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxName.Location = new Point(119, 93);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(672, 40);
			textBoxName.TabIndex = 18;
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelName.Location = new Point(10, 96);
			labelName.Name = "labelName";
			labelName.Size = new Size(87, 33);
			labelName.TabIndex = 17;
			labelName.Text = "Name:";
			// 
			// textBoxFrom
			// 
			textBoxFrom.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxFrom.Location = new Point(119, 26);
			textBoxFrom.Name = "textBoxFrom";
			textBoxFrom.ReadOnly = true;
			textBoxFrom.Size = new Size(672, 40);
			textBoxFrom.TabIndex = 16;
			// 
			// labelFrom
			// 
			labelFrom.AutoSize = true;
			labelFrom.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelFrom.Location = new Point(10, 29);
			labelFrom.Name = "labelFrom";
			labelFrom.Size = new Size(79, 33);
			labelFrom.TabIndex = 15;
			labelFrom.Text = "From:";
			// 
			// SendEmailForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(806, 1023);
			Controls.Add(buttonSend);
			Controls.Add(buttonBrowse);
			Controls.Add(textBoxAttachmentPaths);
			Controls.Add(labelAttachment);
			Controls.Add(richTextBoxBody);
			Controls.Add(checkBoxIsHTML);
			Controls.Add(labelBody);
			Controls.Add(textBoxSubject);
			Controls.Add(labelSubject);
			Controls.Add(textBoxTo);
			Controls.Add(labelTo);
			Controls.Add(textBoxName);
			Controls.Add(labelName);
			Controls.Add(textBoxFrom);
			Controls.Add(labelFrom);
			Name = "SendEmailForm";
			Text = "Send Email";
			Load += SendEmailForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonSend;
		private Button buttonBrowse;
		private TextBox textBoxAttachmentPaths;
		private Label labelAttachment;
		private RichTextBox richTextBoxBody;
		private CheckBox checkBoxIsHTML;
		private Label labelBody;
		private TextBox textBoxSubject;
		private Label labelSubject;
		private TextBox textBoxTo;
		private Label labelTo;
		private TextBox textBoxName;
		private Label labelName;
		private TextBox textBoxFrom;
		private Label labelFrom;
	}
}