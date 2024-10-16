namespace OrderManagement_Desktop.View
{
    partial class Home
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
            ButtonViewProducts = new Button();
            ButtonViewOrders = new Button();
            SuspendLayout();
            // 
            // ButtonViewProducts
            // 
            ButtonViewProducts.Location = new Point(54, 44);
            ButtonViewProducts.Name = "ButtonViewProducts";
            ButtonViewProducts.Size = new Size(102, 47);
            ButtonViewProducts.TabIndex = 0;
            ButtonViewProducts.Text = "PRODUCTS";
            ButtonViewProducts.UseVisualStyleBackColor = true;
            ButtonViewProducts.Click += ButtonViewProducts_Click;
            // 
            // ButtonViewOrders
            // 
            ButtonViewOrders.Location = new Point(191, 44);
            ButtonViewOrders.Name = "ButtonViewOrders";
            ButtonViewOrders.Size = new Size(102, 47);
            ButtonViewOrders.TabIndex = 1;
            ButtonViewOrders.Text = "ORDERS";
            ButtonViewOrders.UseVisualStyleBackColor = true;
            ButtonViewOrders.Click += ButtonViewOrders_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonViewOrders);
            Controls.Add(ButtonViewProducts);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonViewProducts;
        private Button ButtonViewOrders;
    }
}