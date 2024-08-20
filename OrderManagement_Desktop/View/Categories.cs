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
    public partial class Categories : Form
    {
        private CategorieServices _categoriesServices;

        public Categories()
        {
            InitializeComponent();
            _categoriesServices = new CategorieServices();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            ViewCategories();
        }


        private async void ViewCategories()
        {
            try
            {
                var categoriesList = await _categoriesServices.GetCategories();
                DataGridViewCategories.DataSource = categoriesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
        }
    }
}
