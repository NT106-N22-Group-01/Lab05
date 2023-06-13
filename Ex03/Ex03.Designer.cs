namespace Ex03
{
    partial class Ex03
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
            label1 = new Label();
            usrText = new TextBox();
            loginButton = new Button();
            output = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            protocolText = new TextBox();
            pwdText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)output).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // usrText
            // 
            usrText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usrText.Location = new Point(140, 30);
            usrText.Name = "usrText";
            usrText.Size = new Size(200, 27);
            usrText.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(375, 41);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 50);
            loginButton.TabIndex = 2;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // output
            // 
            output.BackgroundColor = SystemColors.Control;
            output.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            output.Location = new Point(30, 180);
            output.Name = "output";
            output.RowTemplate.Height = 25;
            output.Size = new Size(460, 240);
            output.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 75);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 120);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Protocol:";
            // 
            // protocolText
            // 
            protocolText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            protocolText.Location = new Point(140, 120);
            protocolText.Name = "protocolText";
            protocolText.Size = new Size(100, 27);
            protocolText.TabIndex = 6;
            // 
            // pwdText
            // 
            pwdText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pwdText.Location = new Point(140, 75);
            pwdText.Name = "pwdText";
            pwdText.Size = new Size(200, 27);
            pwdText.TabIndex = 7;
            // 
            // Ex03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 441);
            Controls.Add(pwdText);
            Controls.Add(protocolText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(output);
            Controls.Add(loginButton);
            Controls.Add(usrText);
            Controls.Add(label1);
            Name = "Ex03";
            Text = "Ex03";
            ((System.ComponentModel.ISupportInitialize)output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usrText;
        private Button loginButton;
        private DataGridView output;
        private Label label2;
        private Label label3;
        private TextBox protocolText;
        private TextBox pwdText;
    }
}