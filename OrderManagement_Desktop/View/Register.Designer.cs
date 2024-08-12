namespace OrderManagement_Desktop.View
{
    partial class Register
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
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPass = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddres = new TextBox();
            ButtonRegister = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(426, 74);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(215, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(426, 141);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(215, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(426, 201);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(215, 23);
            textBoxPass.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(426, 268);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(215, 23);
            textBoxPhone.TabIndex = 3;
            // 
            // textBoxAddres
            // 
            textBoxAddres.Location = new Point(426, 337);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(215, 23);
            textBoxAddres.TabIndex = 4;
            // 
            // ButtonRegister
            // 
            ButtonRegister.Location = new Point(426, 397);
            ButtonRegister.Name = "ButtonRegister";
            ButtonRegister.Size = new Size(215, 41);
            ButtonRegister.TabIndex = 5;
            ButtonRegister.Text = "Register";
            ButtonRegister.UseVisualStyleBackColor = true;
            ButtonRegister.Click += ButtonRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 461);
            Controls.Add(ButtonRegister);
            Controls.Add(textBoxAddres);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPass;
        private TextBox textBoxPhone;
        private TextBox textBoxAddres;
        private Button ButtonRegister;
    }
}