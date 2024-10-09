using OrderManagement_Desktop.Services;
using OrderManagement_Desktop.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement_Desktop.View
{
    public partial class Categories : Form
    {
        private CategorieServices _categoriesServices;
        private CategorieServices __categoriesServicesToken;

        public Categories()
        {
            InitializeComponent();
            var token = ConfigurationHelper.GetTokenFromConfig();
            _categoriesServices = new CategorieServices();
            __categoriesServicesToken = new CategorieServices(token);
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
        private async void AddCategorie()
        {
          

                var newCategorie = new Models.Categories
                {
                    Name = TextBoxNewCategorie.Text

                };


                var json = JsonSerializer.Serialize(newCategorie);

                var result = await _categoriesServices.AddCategorie(newCategorie);
                MessageBox.Show(json.ToString());

                if (result)
                {
                    MessageBox.Show("New Categorie add");
                }
                else
                {
                    MessageBox.Show("Error al añadir el Categorie.");
                }
         
        }

        private void ButtonAddCategories_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteCategorie_Click(object sender, EventArgs e)
        {

        }

        private void ButtonConfirmation_Click(object sender, EventArgs e)
        {
            AddCategorie();
        }
    }
}
