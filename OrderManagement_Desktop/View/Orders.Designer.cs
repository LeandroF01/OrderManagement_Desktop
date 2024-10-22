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
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Location = new Point(101, 51);
            flowLayoutPanel1.MinimumSize = new Size(600, 400);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 400);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // ButtonPending
            // 
            ButtonPending.Location = new Point(379, 482);
            ButtonPending.Name = "ButtonPending";
            ButtonPending.Size = new Size(89, 30);
            ButtonPending.TabIndex = 2;
            ButtonPending.Text = "ButtoPending";
            ButtonPending.UseVisualStyleBackColor = true;
            ButtonPending.Click += ButtonPending_Click;
            // 
            // ButtonProgress
            // 
            ButtonProgress.Location = new Point(493, 482);
            ButtonProgress.Name = "ButtonProgress";
            ButtonProgress.Size = new Size(89, 30);
            ButtonProgress.TabIndex = 3;
            ButtonProgress.Text = "button2";
            ButtonProgress.UseVisualStyleBackColor = true;
            ButtonProgress.Click += ButtonProgress_Click;
            // 
            // ButtonCompleted
            // 
            ButtonCompleted.Location = new Point(612, 482);
            ButtonCompleted.Name = "ButtonCompleted";
            ButtonCompleted.Size = new Size(89, 30);
            ButtonCompleted.TabIndex = 4;
            ButtonCompleted.Text = "button3";
            ButtonCompleted.UseVisualStyleBackColor = true;
            ButtonCompleted.Click += ButtonCompleted_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 524);
            Controls.Add(ButtonCompleted);
            Controls.Add(ButtonProgress);
            Controls.Add(ButtonPending);
            Controls.Add(flowLayoutPanel1);
            Name = "Orders";
            Text = " ";
            Load += Orders_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button ButtonPending;
        private Button ButtonProgress;
        private Button ButtonCompleted;
    }
}