namespace OrderManagement_Desktop.View
{
    partial class Ingredient
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
            DataGridViewIngredients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridViewIngredients).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewIngredients
            // 
            DataGridViewIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewIngredients.Location = new Point(39, 70);
            DataGridViewIngredients.Name = "DataGridViewIngredients";
            DataGridViewIngredients.Size = new Size(289, 197);
            DataGridViewIngredients.TabIndex = 0;
            // 
            // Ingredient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 450);
            Controls.Add(DataGridViewIngredients);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Ingredient";
            Text = "Ingredient";
            Load += ProductIngredient_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewIngredients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewIngredients;
    }
}