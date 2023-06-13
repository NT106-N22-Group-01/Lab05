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
			lbSubject = new Label();
			label2 = new Label();
			label3 = new Label();
			lbFrom = new Label();
			lbTo = new Label();
			webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
			((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
			SuspendLayout();
			// 
			// lbSubject
			// 
			lbSubject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lbSubject.Location = new Point(17, 25);
			lbSubject.Margin = new Padding(4, 0, 4, 0);
			lbSubject.Name = "lbSubject";
			lbSubject.Size = new Size(947, 50);
			lbSubject.TabIndex = 1;
			lbSubject.Text = "Subject";
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(17, 113);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(70, 25);
			label2.TabIndex = 2;
			label2.Text = "From:";
			label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(17, 172);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(70, 25);
			label3.TabIndex = 3;
			label3.Text = "To:";
			label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbFrom
			// 
			lbFrom.AutoSize = true;
			lbFrom.Location = new Point(116, 115);
			lbFrom.Margin = new Padding(4, 0, 4, 0);
			lbFrom.Name = "lbFrom";
			lbFrom.Size = new Size(51, 25);
			lbFrom.TabIndex = 4;
			lbFrom.Text = "from";
			// 
			// lbTo
			// 
			lbTo.AutoSize = true;
			lbTo.Location = new Point(116, 173);
			lbTo.Margin = new Padding(4, 0, 4, 0);
			lbTo.Name = "lbTo";
			lbTo.Size = new Size(29, 25);
			lbTo.TabIndex = 5;
			lbTo.Text = "to";
			// 
			// webView2
			// 
			webView2.AllowExternalDrop = true;
			webView2.CreationProperties = null;
			webView2.DefaultBackgroundColor = Color.White;
			webView2.Location = new Point(12, 238);
			webView2.Name = "webView2";
			webView2.Size = new Size(952, 488);
			webView2.TabIndex = 6;
			webView2.ZoomFactor = 1D;
			// 
			// EmailDetailForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(981, 750);
			Controls.Add(webView2);
			Controls.Add(lbTo);
			Controls.Add(lbFrom);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(lbSubject);
			Margin = new Padding(4, 5, 4, 5);
			Name = "EmailDetailForm";
			Text = "EmailDetailForm";
			Load += EmailDetailForm_Load;
			((System.ComponentModel.ISupportInitialize)webView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lbSubject;
		private Label label2;
		private Label label3;
		private Label lbFrom;
		private Label lbTo;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
	}
}