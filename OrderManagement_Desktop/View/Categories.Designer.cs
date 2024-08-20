namespace OrderManagement_Desktop.View
{
    partial class Categories
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
            DataGridViewCategories = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewCategories
            // 
            DataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCategories.Location = new Point(48, 57);
            DataGridViewCategories.Name = "DataGridViewCategories";
            DataGridViewCategories.Size = new Size(306, 274);
            DataGridViewCategories.TabIndex = 0;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(DataGridViewCategories);
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewCategories;
    }
}