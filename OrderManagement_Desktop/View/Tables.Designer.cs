namespace OrderManagement_Desktop.View
{
    partial class Tables
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
            PanelProducts = new Panel();
            ButtonAddProduct = new Button();
            TextBoxCant = new TextBox();
            TextBoxSearch = new TextBox();
            TextBoxCod = new TextBox();
            ComboBoxCategories = new ComboBox();
            DataGridViewAddProducts = new DataGridView();
            DataGridViewProductsGrid = new DataGridView();
            PanelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAddProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProductsGrid).BeginInit();
            SuspendLayout();
            // 
            // PanelProducts
            // 
            PanelProducts.Controls.Add(ButtonAddProduct);
            PanelProducts.Controls.Add(TextBoxCant);
            PanelProducts.Controls.Add(TextBoxSearch);
            PanelProducts.Controls.Add(TextBoxCod);
            PanelProducts.Controls.Add(ComboBoxCategories);
            PanelProducts.Controls.Add(DataGridViewAddProducts);
            PanelProducts.Controls.Add(DataGridViewProductsGrid);
            PanelProducts.Dock = DockStyle.Fill;
            PanelProducts.Location = new Point(0, 0);
            PanelProducts.Name = "PanelProducts";
            PanelProducts.Size = new Size(975, 519);
            PanelProducts.TabIndex = 0;
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Location = new Point(302, 143);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(75, 23);
            ButtonAddProduct.TabIndex = 6;
            ButtonAddProduct.Text = "button1";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // TextBoxCant
            // 
            TextBoxCant.Location = new Point(72, 144);
            TextBoxCant.Name = "TextBoxCant";
            TextBoxCant.Size = new Size(100, 23);
            TextBoxCant.TabIndex = 5;
            TextBoxCant.Text = "1";
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(72, 76);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(183, 23);
            TextBoxSearch.TabIndex = 4;
            // 
            // TextBoxCod
            // 
            TextBoxCod.Location = new Point(72, 115);
            TextBoxCod.Name = "TextBoxCod";
            TextBoxCod.Size = new Size(100, 23);
            TextBoxCod.TabIndex = 3;
            // 
            // ComboBoxCategories
            // 
            ComboBoxCategories.FormattingEnabled = true;
            ComboBoxCategories.Location = new Point(72, 36);
            ComboBoxCategories.Name = "ComboBoxCategories";
            ComboBoxCategories.Size = new Size(183, 23);
            ComboBoxCategories.TabIndex = 2;
            // 
            // DataGridViewAddProducts
            // 
            DataGridViewAddProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewAddProducts.Location = new Point(636, 173);
            DataGridViewAddProducts.Name = "DataGridViewAddProducts";
            DataGridViewAddProducts.Size = new Size(240, 324);
            DataGridViewAddProducts.TabIndex = 1;
            // 
            // DataGridViewProductsGrid
            // 
            DataGridViewProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProductsGrid.Location = new Point(72, 173);
            DataGridViewProductsGrid.Name = "DataGridViewProductsGrid";
            DataGridViewProductsGrid.Size = new Size(305, 324);
            DataGridViewProductsGrid.TabIndex = 0;
            // 
            // Tables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 519);
            Controls.Add(PanelProducts);
            Name = "Tables";
            Text = "Tables";
            Load += Tables_Load;
            PanelProducts.ResumeLayout(false);
            PanelProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAddProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProductsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelProducts;
        private DataGridView DataGridViewProductsGrid;
        private DataGridView DataGridViewAddProducts;
        private ComboBox ComboBoxCategories;
        private Button ButtonAddProduct;
        private TextBox TextBoxCant;
        private TextBox TextBoxSearch;
        private TextBox TextBoxCod;
    }
}