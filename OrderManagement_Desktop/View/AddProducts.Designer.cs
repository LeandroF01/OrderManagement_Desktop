﻿namespace OrderManagement_Desktop.View
{
    partial class AddProducts
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            ComboBoxCategories = new ComboBox();
            richTextBox1 = new RichTextBox();
            ListBoxIngredientes = new ListBox();
            DataGridViewAddIngredientes = new DataGridView();
            ButtonConfirmIngredient = new Button();
            TextBoxIngredientes = new TextBox();
            TextBoxAmountIngredients = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAddIngredientes).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 23);
            textBox3.TabIndex = 2;
            // 
            // ComboBoxCategories
            // 
            ComboBoxCategories.FormattingEnabled = true;
            ComboBoxCategories.Location = new Point(40, 213);
            ComboBoxCategories.Name = "ComboBoxCategories";
            ComboBoxCategories.Size = new Size(233, 23);
            ComboBoxCategories.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(40, 88);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(233, 43);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // ListBoxIngredientes
            // 
            ListBoxIngredientes.FormattingEnabled = true;
            ListBoxIngredientes.ItemHeight = 15;
            ListBoxIngredientes.Location = new Point(432, 77);
            ListBoxIngredientes.Name = "ListBoxIngredientes";
            ListBoxIngredientes.Size = new Size(163, 109);
            ListBoxIngredientes.TabIndex = 7;
            // 
            // DataGridViewAddIngredientes
            // 
            DataGridViewAddIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewAddIngredientes.Location = new Point(40, 268);
            DataGridViewAddIngredientes.Name = "DataGridViewAddIngredientes";
            DataGridViewAddIngredientes.Size = new Size(233, 150);
            DataGridViewAddIngredientes.TabIndex = 8;
            // 
            // ButtonConfirmIngredient
            // 
            ButtonConfirmIngredient.Location = new Point(616, 145);
            ButtonConfirmIngredient.Name = "ButtonConfirmIngredient";
            ButtonConfirmIngredient.Size = new Size(95, 41);
            ButtonConfirmIngredient.TabIndex = 9;
            ButtonConfirmIngredient.Text = "button1";
            ButtonConfirmIngredient.UseVisualStyleBackColor = true;
            ButtonConfirmIngredient.Click += ButtonConfirmIngredient_Click;
            // 
            // TextBoxIngredientes
            // 
            TextBoxIngredientes.Location = new Point(432, 43);
            TextBoxIngredientes.Name = "TextBoxIngredientes";
            TextBoxIngredientes.Size = new Size(163, 23);
            TextBoxIngredientes.TabIndex = 10;
            // 
            // TextBoxAmountIngredients
            // 
            TextBoxAmountIngredients.Location = new Point(616, 108);
            TextBoxAmountIngredients.Name = "TextBoxAmountIngredients";
            TextBoxAmountIngredients.Size = new Size(95, 23);
            TextBoxAmountIngredients.TabIndex = 11;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(TextBoxAmountIngredients);
            Controls.Add(TextBoxIngredientes);
            Controls.Add(ButtonConfirmIngredient);
            Controls.Add(DataGridViewAddIngredientes);
            Controls.Add(ListBoxIngredientes);
            Controls.Add(richTextBox1);
            Controls.Add(ComboBoxCategories);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "AddProducts";
            Text = "AddProducts";
            Load += AddProducts_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewAddIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private ComboBox ComboBoxCategories;
        private RichTextBox richTextBox1;
        private ListBox ListBoxIngredientes;
        private DataGridView DataGridViewAddIngredientes;
        private Button ButtonConfirmIngredient;
        private TextBox TextBoxIngredientes;
        private TextBox TextBoxAmountIngredients;
    }
}