namespace OrderManagement_Desktop.View
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
            ListBoxIngredientes.Location = new Point(579, 66);
            ListBoxIngredientes.Name = "ListBoxIngredientes";
            ListBoxIngredientes.Size = new Size(120, 94);
            ListBoxIngredientes.TabIndex = 7;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListBoxIngredientes);
            Controls.Add(richTextBox1);
            Controls.Add(ComboBoxCategories);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "AddProducts";
            Text = "AddProducts";
            Load += AddProducts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private ComboBox ComboBoxCategories;
        private RichTextBox richTextBox1;
        private ListBox ListBoxIngredientes;
    }
}