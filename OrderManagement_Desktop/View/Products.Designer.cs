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
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridViewProducts);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewProducts;
    }
}