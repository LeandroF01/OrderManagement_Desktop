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
            TextBoxProductName = new TextBox();
            TextBoxProductPrice = new TextBox();
            ComboBoxCategories = new ComboBox();
            RichTextBoxProductDescription = new RichTextBox();
            ListBoxIngredientes = new ListBox();
            DataGridViewAddIngredientes = new DataGridView();
            ButtonConfirmIngredient = new Button();
            TextBoxIngredientes = new TextBox();
            TextBoxAmountIngredients = new TextBox();
            ButtonAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAddIngredientes).BeginInit();
            SuspendLayout();
            // 
            // TextBoxProductName
            // 
            TextBoxProductName.Location = new Point(40, 43);
            TextBoxProductName.Name = "TextBoxProductName";
            TextBoxProductName.Size = new Size(233, 23);
            TextBoxProductName.TabIndex = 0;
            // 
            // TextBoxProductPrice
            // 
            TextBoxProductPrice.Location = new Point(40, 154);
            TextBoxProductPrice.Name = "TextBoxProductPrice";
            TextBoxProductPrice.Size = new Size(233, 23);
            TextBoxProductPrice.TabIndex = 2;
            // 
            // ComboBoxCategories
            // 
            ComboBoxCategories.FormattingEnabled = true;
            ComboBoxCategories.Location = new Point(40, 213);
            ComboBoxCategories.Name = "ComboBoxCategories";
            ComboBoxCategories.Size = new Size(233, 23);
            ComboBoxCategories.TabIndex = 5;
            // 
            // RichTextBoxProductDescription
            // 
            RichTextBoxProductDescription.BorderStyle = BorderStyle.FixedSingle;
            RichTextBoxProductDescription.Location = new Point(40, 88);
            RichTextBoxProductDescription.Name = "RichTextBoxProductDescription";
            RichTextBoxProductDescription.Size = new Size(233, 43);
            RichTextBoxProductDescription.TabIndex = 6;
            RichTextBoxProductDescription.Text = "";
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
            // ButtonAddProduct
            // 
            ButtonAddProduct.Location = new Point(584, 370);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(127, 48);
            ButtonAddProduct.TabIndex = 12;
            ButtonAddProduct.Text = "button1";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            ButtonAddProduct.Click += ButtonAddProduct_Click;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(ButtonAddProduct);
            Controls.Add(TextBoxAmountIngredients);
            Controls.Add(TextBoxIngredientes);
            Controls.Add(ButtonConfirmIngredient);
            Controls.Add(DataGridViewAddIngredientes);
            Controls.Add(ListBoxIngredientes);
            Controls.Add(RichTextBoxProductDescription);
            Controls.Add(ComboBoxCategories);
            Controls.Add(TextBoxProductPrice);
            Controls.Add(TextBoxProductName);
            Name = "AddProducts";
            Text = "AddProducts";
            Load += AddProducts_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewAddIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxProductName;
        private TextBox TextBoxProductPrice;
        private ComboBox ComboBoxCategories;
        private RichTextBox RichTextBoxProductDescription;
        private ListBox ListBoxIngredientes;
        private DataGridView DataGridViewAddIngredientes;
        private Button ButtonConfirmIngredient;
        private TextBox TextBoxIngredientes;
        private TextBox TextBoxAmountIngredients;
        private Button ButtonAddProduct;
    }
}