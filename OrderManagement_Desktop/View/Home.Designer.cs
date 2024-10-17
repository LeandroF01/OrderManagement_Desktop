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
            panel1 = new Panel();
            ButtonConfiguration = new Button();
            ButtonPayments = new Button();
            ButtonTables = new Button();
            ButtonOrders = new Button();
            ButtonProducts = new Button();
            ButtonHome = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ButtonConfiguration);
            panel1.Controls.Add(ButtonPayments);
            panel1.Controls.Add(ButtonTables);
            panel1.Controls.Add(ButtonOrders);
            panel1.Controls.Add(ButtonProducts);
            panel1.Controls.Add(ButtonHome);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 761);
            panel1.TabIndex = 2;
            // 
            // ButtonConfiguration
            // 
            ButtonConfiguration.Dock = DockStyle.Bottom;
            ButtonConfiguration.FlatAppearance.BorderColor = Color.White;
            ButtonConfiguration.FlatStyle = FlatStyle.Flat;
            ButtonConfiguration.Location = new Point(0, 721);
            ButtonConfiguration.Name = "ButtonConfiguration";
            ButtonConfiguration.Size = new Size(200, 40);
            ButtonConfiguration.TabIndex = 8;
            ButtonConfiguration.Text = "CONFIGURATION";
            ButtonConfiguration.UseVisualStyleBackColor = true;
            ButtonConfiguration.Click += ButtonConfiguration_Click;
            // 
            // ButtonPayments
            // 
            ButtonPayments.Dock = DockStyle.Top;
            ButtonPayments.FlatAppearance.BorderColor = Color.White;
            ButtonPayments.FlatStyle = FlatStyle.Flat;
            ButtonPayments.Location = new Point(0, 229);
            ButtonPayments.Name = "ButtonPayments";
            ButtonPayments.Size = new Size(200, 40);
            ButtonPayments.TabIndex = 7;
            ButtonPayments.Text = "SALES AND PAYMENTS";
            ButtonPayments.UseVisualStyleBackColor = true;
            ButtonPayments.Click += ButtonPayments_Click;
            // 
            // ButtonTables
            // 
            ButtonTables.Dock = DockStyle.Top;
            ButtonTables.FlatAppearance.BorderColor = Color.White;
            ButtonTables.FlatStyle = FlatStyle.Flat;
            ButtonTables.Location = new Point(0, 189);
            ButtonTables.Name = "ButtonTables";
            ButtonTables.Size = new Size(200, 40);
            ButtonTables.TabIndex = 6;
            ButtonTables.Text = "TABLES";
            ButtonTables.UseVisualStyleBackColor = true;
            ButtonTables.Click += ButtonTables_Click;
            // 
            // ButtonOrders
            // 
            ButtonOrders.Dock = DockStyle.Top;
            ButtonOrders.FlatAppearance.BorderColor = Color.White;
            ButtonOrders.FlatStyle = FlatStyle.Flat;
            ButtonOrders.Location = new Point(0, 149);
            ButtonOrders.Name = "ButtonOrders";
            ButtonOrders.Size = new Size(200, 40);
            ButtonOrders.TabIndex = 5;
            ButtonOrders.Text = "ORDERS";
            ButtonOrders.UseVisualStyleBackColor = true;
            ButtonOrders.Click += ButtonOrders_Click;
            // 
            // ButtonProducts
            // 
            ButtonProducts.Dock = DockStyle.Top;
            ButtonProducts.FlatAppearance.BorderColor = Color.White;
            ButtonProducts.FlatStyle = FlatStyle.Flat;
            ButtonProducts.Location = new Point(0, 109);
            ButtonProducts.Name = "ButtonProducts";
            ButtonProducts.Size = new Size(200, 40);
            ButtonProducts.TabIndex = 4;
            ButtonProducts.Text = "PRODUCTS";
            ButtonProducts.UseVisualStyleBackColor = true;
            ButtonProducts.Click += ButtonProducts_Click;
            // 
            // ButtonHome
            // 
            ButtonHome.Dock = DockStyle.Top;
            ButtonHome.FlatAppearance.BorderColor = Color.White;
            ButtonHome.FlatStyle = FlatStyle.Flat;
            ButtonHome.Location = new Point(0, 69);
            ButtonHome.Name = "ButtonHome";
            ButtonHome.Size = new Size(200, 40);
            ButtonHome.TabIndex = 3;
            ButtonHome.Text = "HOME";
            ButtonHome.UseVisualStyleBackColor = true;
            ButtonHome.Click += ButtonHome_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 69);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 761);
            panel2.TabIndex = 3;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1200, 800);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonViewProducts;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button ButtonTables;
        private Button button2;
        private Button ButtonHome;
        private Button ButtonPayments;
        private Button ButtonOrders;
        private Button ButtonProducts;
        private Button ButtonConfiguration;
    }
}