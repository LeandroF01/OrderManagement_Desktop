using OrderManagement_Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    }
}
