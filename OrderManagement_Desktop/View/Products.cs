using OrderManagement_Desktop.Services;
using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OrderManagement_Desktop.View
{
    public partial class Products : Form
    {
        private ProductServices _productServices;

        public Products()
        {
            InitializeComponent();
            _productServices = new ProductServices();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            ViewProducts();
        }

        public async void ViewProducts()
        {
            try
            {
                var productList = await _productServices.GetProducts();
                DataGridViewProducts.DataSource = productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
        }



        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            AddProducts addProductsForm = new AddProducts();

            addProductsForm.ShowDialog();
        }

        private void ButtonViewCategories_Click(object sender, EventArgs e)
        {
            Categories categoriesForm = new Categories();

            categoriesForm.ShowDialog();
        }

        private void ButtonViewIngredients_Click(object sender, EventArgs e)
        {
            Ingredient ingredientForm = new Ingredient();

            ingredientForm.ShowDialog();
        }
    }
}
