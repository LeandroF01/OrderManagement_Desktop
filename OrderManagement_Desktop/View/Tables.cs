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
        public Tables()
        {
            InitializeComponent();
            _productServices = new ProductServices();
        }
        private void Tables_Load(object sender, EventArgs e)
        {
            ViewProducts();
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

    }
}
