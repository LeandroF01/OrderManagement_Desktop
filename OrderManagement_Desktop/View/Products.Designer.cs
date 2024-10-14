namespace OrderManagement_Desktop.View
{
    partial class Products
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
            DataGridViewProducts = new DataGridView();
            ButtonAddProduct = new Button();
            ButtonViewCategories = new Button();
            ButtonViewIngredients = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewProducts
            // 
            DataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProducts.Location = new Point(59, 84);
            DataGridViewProducts.Name = "DataGridViewProducts";
            DataGridViewProducts.Size = new Size(639, 238);
            DataGridViewProducts.TabIndex = 0;
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Location = new Point(605, 377);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(40, 43);
            ButtonAddProduct.TabIndex = 1;
            ButtonAddProduct.Text = "+";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            ButtonAddProduct.Click += ButtonAddProduct_Click;
            // 
            // ButtonViewCategories
            // 
            ButtonViewCategories.Location = new Point(561, 12);
            ButtonViewCategories.Name = "ButtonViewCategories";
            ButtonViewCategories.Size = new Size(102, 47);
            ButtonViewCategories.TabIndex = 2;
            ButtonViewCategories.Text = "CATEGORIES";
            ButtonViewCategories.UseVisualStyleBackColor = true;
            ButtonViewCategories.Click += ButtonViewCategories_Click;
            // 
            // ButtonViewIngredients
            // 
            ButtonViewIngredients.Location = new Point(669, 12);
            ButtonViewIngredients.Name = "ButtonViewIngredients";
            ButtonViewIngredients.Size = new Size(102, 47);
            ButtonViewIngredients.TabIndex = 3;
            ButtonViewIngredients.Text = "INGREDIENTS";
            ButtonViewIngredients.UseVisualStyleBackColor = true;
            ButtonViewIngredients.Click += ButtonViewIngredients_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonViewIngredients);
            Controls.Add(ButtonViewCategories);
            Controls.Add(ButtonAddProduct);
            Controls.Add(DataGridViewProducts);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewProducts;
        private Button ButtonAddProduct;
        private Button ButtonViewCategories;
        private Button ButtonViewIngredients;
    }
}