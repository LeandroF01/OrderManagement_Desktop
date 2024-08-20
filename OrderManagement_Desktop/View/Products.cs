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

        private async void  ViewProducts()
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

        private async void AddProduct()
        {
            try
            {
                var newProduct = new Models.Products
                {
                    Name = "",
                    Description = "",
                    Price = 0,
                    CategoryID = 0,
                    Stock = 0,
                    ImageURL = ""
                }; 

                var result = await _productServices.AddProduct(newProduct);

                if (result)
                {
                    MessageBox.Show("Producto añadido con éxito.");
                    ViewProducts(); 
                }
                else
                {
                    MessageBox.Show("Error al añadir el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void UpdateProduct()
        {
            try
            {

                var updatedProduct = new Models.Products
                {
                    Name = "",
                    Description = "",
                    Price = 0,
                    CategoryID = 0,
                    Stock = 0,
                    ImageURL = ""
                };

                var result = await _productServices.UpdateProduct(updatedProduct);

                if (result)
                {
                    MessageBox.Show("Producto actualizado con éxito.");
                    ViewProducts();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }




    }
}
