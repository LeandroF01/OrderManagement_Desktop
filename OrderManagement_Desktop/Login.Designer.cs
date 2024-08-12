namespace OrderManagement_Desktop
{
    partial class Login
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
            textBoxEmail = new TextBox();
            textBoxPass = new TextBox();
            ButtonLogin = new Button();
            ButtonRegister = new Button();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(66, 149);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(198, 23);
            textBoxEmail.TabIndex = 0;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(66, 244);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(198, 23);
            textBoxPass.TabIndex = 1;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(66, 331);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(198, 50);
            ButtonLogin.TabIndex = 2;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // ButtonRegister
            // 
            ButtonRegister.Location = new Point(66, 398);
            ButtonRegister.Name = "ButtonRegister";
            ButtonRegister.Size = new Size(198, 25);
            ButtonRegister.TabIndex = 3;
            ButtonRegister.Text = "Register";
            ButtonRegister.UseVisualStyleBackColor = true;
            ButtonRegister.Click += ButtonRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 450);
            Controls.Add(ButtonRegister);
            Controls.Add(ButtonLogin);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxEmail);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private TextBox textBoxPass;
        private Button ButtonLogin;
        private Button ButtonRegister;
    }
}
