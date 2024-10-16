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
            ButtonAddIngredient = new Button();
            ButtonDeleteIngredient = new Button();
            PanelAddIngredient = new Panel();
            ButtonCancel = new Button();
            ButtonConfirm = new Button();
            TextBoxUnit = new TextBox();
            TextBoxQuantity = new TextBox();
            TextBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridViewIngredients).BeginInit();
            PanelAddIngredient.SuspendLayout();
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
            // ButtonAddIngredient
            // 
            ButtonAddIngredient.Location = new Point(253, 325);
            ButtonAddIngredient.Name = "ButtonAddIngredient";
            ButtonAddIngredient.Size = new Size(75, 23);
            ButtonAddIngredient.TabIndex = 1;
            ButtonAddIngredient.Text = "button1";
            ButtonAddIngredient.UseVisualStyleBackColor = true;
            ButtonAddIngredient.Click += ButtonAddIngredient_Click;
            // 
            // ButtonDeleteIngredient
            // 
            ButtonDeleteIngredient.Location = new Point(172, 325);
            ButtonDeleteIngredient.Name = "ButtonDeleteIngredient";
            ButtonDeleteIngredient.Size = new Size(75, 25);
            ButtonDeleteIngredient.TabIndex = 2;
            ButtonDeleteIngredient.Text = "button2";
            ButtonDeleteIngredient.UseVisualStyleBackColor = true;
            ButtonDeleteIngredient.Click += ButtonDeleteIngredient_Click;
            // 
            // PanelAddIngredient
            // 
            PanelAddIngredient.Controls.Add(ButtonCancel);
            PanelAddIngredient.Controls.Add(ButtonConfirm);
            PanelAddIngredient.Controls.Add(TextBoxUnit);
            PanelAddIngredient.Controls.Add(TextBoxQuantity);
            PanelAddIngredient.Controls.Add(TextBoxName);
            PanelAddIngredient.Location = new Point(53, 46);
            PanelAddIngredient.Name = "PanelAddIngredient";
            PanelAddIngredient.Size = new Size(258, 262);
            PanelAddIngredient.TabIndex = 3;
            PanelAddIngredient.Visible = false;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(143, 213);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 4;
            ButtonCancel.Text = "button2";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonConfirm
            // 
            ButtonConfirm.Location = new Point(38, 213);
            ButtonConfirm.Name = "ButtonConfirm";
            ButtonConfirm.Size = new Size(75, 23);
            ButtonConfirm.TabIndex = 3;
            ButtonConfirm.Text = "button1";
            ButtonConfirm.UseVisualStyleBackColor = true;
            ButtonConfirm.Click += ButtonConfirm_Click;
            // 
            // TextBoxUnit
            // 
            TextBoxUnit.Location = new Point(183, 99);
            TextBoxUnit.Name = "TextBoxUnit";
            TextBoxUnit.Size = new Size(35, 23);
            TextBoxUnit.TabIndex = 2;
            // 
            // TextBoxQuantity
            // 
            TextBoxQuantity.Location = new Point(38, 99);
            TextBoxQuantity.Name = "TextBoxQuantity";
            TextBoxQuantity.Size = new Size(125, 23);
            TextBoxQuantity.TabIndex = 1;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(38, 50);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(180, 23);
            TextBoxName.TabIndex = 0;
            // 
            // Ingredient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 413);
            Controls.Add(PanelAddIngredient);
            Controls.Add(ButtonDeleteIngredient);
            Controls.Add(ButtonAddIngredient);
            Controls.Add(DataGridViewIngredients);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Ingredient";
            Text = "Ingredient";
            Load += ProductIngredient_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewIngredients).EndInit();
            PanelAddIngredient.ResumeLayout(false);
            PanelAddIngredient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewIngredients;
        private Button ButtonAddIngredient;
        private Button ButtonDeleteIngredient;
        private Panel PanelAddIngredient;
        private TextBox TextBoxQuantity;
        private TextBox TextBoxName;
        private Button ButtonCancel;
        private Button ButtonConfirm;
        private TextBox TextBoxUnit;
    }
}