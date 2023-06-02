namespace Ex04
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
			labelFrom = new Label();
			labelTo = new Label();
			labelToText = new Label();
			labelFromText = new Label();
			labelSubject = new Label();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
			((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
			SuspendLayout();
			// 
			// labelFrom
			// 
			labelFrom.AutoSize = true;
			labelFrom.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelFrom.Location = new Point(22, 25);
			labelFrom.Name = "labelFrom";
			labelFrom.Size = new Size(79, 33);
			labelFrom.TabIndex = 0;
			labelFrom.Text = "From:";
			// 
			// labelTo
			// 
			labelTo.AutoSize = true;
			labelTo.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelTo.Location = new Point(22, 72);
			labelTo.Name = "labelTo";
			labelTo.Size = new Size(48, 33);
			labelTo.TabIndex = 1;
			labelTo.Text = "To:";
			// 
			// labelToText
			// 
			labelToText.AutoSize = true;
			labelToText.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelToText.Location = new Point(118, 72);
			labelToText.Name = "labelToText";
			labelToText.Size = new Size(37, 33);
			labelToText.TabIndex = 3;
			labelToText.Text = "to";
			// 
			// labelFromText
			// 
			labelFromText.AutoSize = true;
			labelFromText.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelFromText.Location = new Point(118, 25);
			labelFromText.Name = "labelFromText";
			labelFromText.Size = new Size(69, 33);
			labelFromText.TabIndex = 2;
			labelFromText.Text = "from";
			// 
			// labelSubject
			// 
			labelSubject.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelSubject.Location = new Point(12, 105);
			labelSubject.Name = "labelSubject";
			labelSubject.Size = new Size(945, 119);
			labelSubject.TabIndex = 4;
			labelSubject.Text = "Subject";
			// 
			// webView2
			// 
			webView2.AllowExternalDrop = true;
			webView2.CreationProperties = null;
			webView2.DefaultBackgroundColor = Color.White;
			webView2.Location = new Point(12, 236);
			webView2.Name = "webView2";
			webView2.Size = new Size(945, 718);
			webView2.TabIndex = 5;
			webView2.ZoomFactor = 1D;
			// 
			// EmailDetailForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(969, 966);
			Controls.Add(webView2);
			Controls.Add(labelSubject);
			Controls.Add(labelToText);
			Controls.Add(labelFromText);
			Controls.Add(labelTo);
			Controls.Add(labelFrom);
			Name = "EmailDetailForm";
			Text = "EmailDetailForm";
			Load += EmailDetailForm_Load;
			((System.ComponentModel.ISupportInitialize)webView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelFrom;
		private Label labelTo;
		private Label labelToText;
		private Label labelFromText;
		private Label labelSubject;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
	}
}