namespace MyFirstWinForms
{
    partial class Form1
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
            loginButton = new Button();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(78, 91);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(224, 41);
            loginButton.TabIndex = 0;
            loginButton.Text = "ورود";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(78, 12);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(224, 23);
            UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(78, 51);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(224, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "نام کاربری";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 54);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "رمزعبور";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 150);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(loginButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
    }
}
