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
            buttonLogin = new Button();
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
            // buttonLogin
            // 
            buttonLogin.Location = new Point(66, 343);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(198, 38);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 450);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxEmail);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private TextBox textBoxPass;
        private Button buttonLogin;
    }
}
