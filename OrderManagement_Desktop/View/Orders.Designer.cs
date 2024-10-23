namespace OrderManagement_Desktop.View
{
    partial class Orders
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            ButtonPending = new Button();
            ButtonProgress = new Button();
            ButtonCompleted = new Button();
            panel1 = new Panel();
            DataGridViewDetalleOrders = new DataGridView();
            ButtonNewOrder = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDetalleOrders).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Location = new Point(24, 76);
            flowLayoutPanel1.MinimumSize = new Size(600, 400);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 400);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // ButtonPending
            // 
            ButtonPending.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonPending.Location = new Point(101, 482);
            ButtonPending.Name = "ButtonPending";
            ButtonPending.Size = new Size(89, 30);
            ButtonPending.TabIndex = 2;
            ButtonPending.Text = "ButtoPending";
            ButtonPending.UseVisualStyleBackColor = true;
            ButtonPending.Click += ButtonPending_Click;
            // 
            // ButtonProgress
            // 
            ButtonProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonProgress.Location = new Point(215, 482);
            ButtonProgress.Name = "ButtonProgress";
            ButtonProgress.Size = new Size(89, 30);
            ButtonProgress.TabIndex = 3;
            ButtonProgress.Text = "button2";
            ButtonProgress.UseVisualStyleBackColor = true;
            ButtonProgress.Click += ButtonProgress_Click;
            // 
            // ButtonCompleted
            // 
            ButtonCompleted.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonCompleted.Location = new Point(326, 482);
            ButtonCompleted.Name = "ButtonCompleted";
            ButtonCompleted.Size = new Size(89, 30);
            ButtonCompleted.TabIndex = 4;
            ButtonCompleted.Text = "button3";
            ButtonCompleted.UseVisualStyleBackColor = true;
            ButtonCompleted.Click += ButtonCompleted_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(ButtonNewOrder);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 70);
            panel1.TabIndex = 6;
            // 
            // DataGridViewDetalleOrders
            // 
            DataGridViewDetalleOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewDetalleOrders.Location = new Point(657, 104);
            DataGridViewDetalleOrders.Name = "DataGridViewDetalleOrders";
            DataGridViewDetalleOrders.Size = new Size(240, 372);
            DataGridViewDetalleOrders.TabIndex = 7;
            // 
            // ButtonNewOrder
            // 
            ButtonNewOrder.Location = new Point(101, 12);
            ButtonNewOrder.Name = "ButtonNewOrder";
            ButtonNewOrder.Size = new Size(91, 55);
            ButtonNewOrder.TabIndex = 5;
            ButtonNewOrder.Text = "button1";
            ButtonNewOrder.UseVisualStyleBackColor = true;
            ButtonNewOrder.Click += ButtonNewOrder_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 524);
            Controls.Add(DataGridViewDetalleOrders);
            Controls.Add(ButtonCompleted);
            Controls.Add(ButtonProgress);
            Controls.Add(ButtonPending);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Orders";
            Text = " ";
            Load += Orders_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewDetalleOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button ButtonPending;
        private Button ButtonProgress;
        private Button ButtonCompleted;
        private Panel panel1;
        private Button ButtonNewOrder;
        private DataGridView DataGridViewDetalleOrders;
    }
}