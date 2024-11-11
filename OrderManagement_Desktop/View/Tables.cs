using Aspose.CAD.FileFormats.Cad.CadConsts;
using Aspose.CAD.FileFormats.Cad.CadObjects;
using Aspose.CAD.FileFormats.Cad;
using AsposeImage = Aspose.CAD.Image;
using OrderManagement_Desktop.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.CAD;
using System.Security.Principal;
using OrderManagement_Desktop.Services;


namespace OrderManagement_Desktop.View
{
    public partial class Tables : Form

    {
        private ProductServices _productServices;
        private CategorieServices _categoriesServices;

        public Tables()
        {
            InitializeComponent();
            _productServices = new ProductServices();
            _categoriesServices = new CategorieServices();
        }
        private void Tables_Load(object sender, EventArgs e)
        {
            ViewProducts();
            ViewCategories();
        }


        public async void ViewProducts()
        {
            try
            {
                var productList = await _productServices.GetProducts();
                DataGridViewProductsGrid.DataSource = productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
        }


        private async Task ViewCategories()
        {
            try
            {
                var categoryList = await _categoriesServices.GetCategories();

                ComboBoxCategories.DisplayMember = "Name";
                ComboBoxCategories.ValueMember = "CategoryID";

                ComboBoxCategories.DataSource = categoryList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}");
            }
        }


        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en DataGridViewProductsGrid
            if (DataGridViewProductsGrid.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                var selectedRow = DataGridViewProductsGrid.SelectedRows[0];

                string productName = selectedRow.Cells["Name"].Value.ToString();
                decimal unitPrice = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                // Obtener la cantidad ingresada en el TextBox
                if (int.TryParse(TextBoxCant.Text, out int quantity) && quantity > 0)
                {
                    // Calcular el total
                    decimal total = unitPrice * quantity;

                    // Agregar una nueva fila a DataGridViewAddProducts con los valores
                    DataGridViewAddProducts.Rows.Add(quantity, productName, unitPrice, total);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para agregar.");
            }
        }
    }
}
