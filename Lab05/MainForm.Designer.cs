﻿namespace Lab05
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			buttonEx1 = new Button();
			buttonEx3 = new Button();
			buttonEx2 = new Button();
			buttonEx4 = new Button();
			buttonExit = new Button();
			SuspendLayout();
			// 
			// buttonEx1
			// 
			buttonEx1.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEx1.Location = new Point(215, 105);
			buttonEx1.Name = "buttonEx1";
			buttonEx1.Size = new Size(129, 53);
			buttonEx1.TabIndex = 0;
			buttonEx1.Text = "Bài 1";
			buttonEx1.UseVisualStyleBackColor = true;
			buttonEx1.Click += buttonEx01_Click;
			// 
			// buttonEx3
			// 
			buttonEx3.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEx3.Location = new Point(215, 208);
			buttonEx3.Name = "buttonEx3";
			buttonEx3.Size = new Size(129, 53);
			buttonEx3.TabIndex = 1;
			buttonEx3.Text = "Bài 3";
			buttonEx3.UseVisualStyleBackColor = true;
			buttonEx3.Click += buttonEx3_Click;
			// 
			// buttonEx2
			// 
			buttonEx2.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEx2.Location = new Point(477, 105);
			buttonEx2.Name = "buttonEx2";
			buttonEx2.Size = new Size(129, 53);
			buttonEx2.TabIndex = 4;
			buttonEx2.Text = "Bài 2";
			buttonEx2.UseVisualStyleBackColor = true;
			buttonEx2.Click += buttonEx2_Click;
			// 
			// buttonEx4
			// 
			buttonEx4.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonEx4.Location = new Point(477, 208);
			buttonEx4.Name = "buttonEx4";
			buttonEx4.Size = new Size(129, 53);
			buttonEx4.TabIndex = 5;
			buttonEx4.Text = "Bài 4";
			buttonEx4.UseVisualStyleBackColor = true;
			buttonEx4.Click += buttonEx4_Click;
			// 
			// buttonExit
			// 
			buttonExit.Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
			buttonExit.Location = new Point(349, 331);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(129, 53);
			buttonExit.TabIndex = 7;
			buttonExit.Text = "Thoát";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 427);
			Controls.Add(buttonExit);
			Controls.Add(buttonEx4);
			Controls.Add(buttonEx2);
			Controls.Add(buttonEx3);
			Controls.Add(buttonEx1);
			Name = "MainForm";
			Text = "Lab 03";
			ResumeLayout(false);
		}

		#endregion

		private Button buttonEx1;
		private Button buttonEx3;
		private Button buttonEx2;
		private Button buttonEx4;
		private Button buttonExit;
	}
}