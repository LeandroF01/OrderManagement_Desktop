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
            ButtonDeleteCategorie = new Button();
            ButtonAddCategories = new Button();
            TextBoxNewCategorie = new TextBox();
            ButtonConfirmation = new Button();
            ButtonCancel = new Button();
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
            // ButtonDeleteCategorie
            // 
            ButtonDeleteCategorie.Location = new Point(198, 415);
            ButtonDeleteCategorie.Name = "ButtonDeleteCategorie";
            ButtonDeleteCategorie.Size = new Size(75, 23);
            ButtonDeleteCategorie.TabIndex = 1;
            ButtonDeleteCategorie.Text = "DELETE";
            ButtonDeleteCategorie.UseVisualStyleBackColor = true;
            ButtonDeleteCategorie.Click += ButtonDeleteCategorie_Click;
            // 
            // ButtonAddCategories
            // 
            ButtonAddCategories.Location = new Point(279, 415);
            ButtonAddCategories.Name = "ButtonAddCategories";
            ButtonAddCategories.Size = new Size(75, 23);
            ButtonAddCategories.TabIndex = 2;
            ButtonAddCategories.Text = "ADD";
            ButtonAddCategories.UseVisualStyleBackColor = true;
            ButtonAddCategories.Click += ButtonAddCategories_Click;
            // 
            // TextBoxNewCategorie
            // 
            TextBoxNewCategorie.Location = new Point(48, 371);
            TextBoxNewCategorie.Name = "TextBoxNewCategorie";
            TextBoxNewCategorie.Size = new Size(100, 23);
            TextBoxNewCategorie.TabIndex = 3;
            // 
            // ButtonConfirmation
            // 
            ButtonConfirmation.Location = new Point(279, 371);
            ButtonConfirmation.Name = "ButtonConfirmation";
            ButtonConfirmation.Size = new Size(75, 23);
            ButtonConfirmation.TabIndex = 4;
            ButtonConfirmation.Text = "1";
            ButtonConfirmation.UseVisualStyleBackColor = true;
            ButtonConfirmation.Click += ButtonConfirmation_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(198, 371);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 5;
            ButtonCancel.Text = "2";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonConfirmation);
            Controls.Add(TextBoxNewCategorie);
            Controls.Add(ButtonAddCategories);
            Controls.Add(ButtonDeleteCategorie);
            Controls.Add(DataGridViewCategories);
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewCategories;
        private Button ButtonDeleteCategorie;
        private Button ButtonAddCategories;
        private TextBox TextBoxNewCategorie;
        private Button ButtonConfirmation;
        private Button ButtonCancel;
    }
}