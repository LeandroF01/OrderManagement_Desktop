using OrderManagement_Desktop.Services;
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

namespace OrderManagement_Desktop.View
{
    public partial class Ingredient : Form
    {

        private IngredientServices _ingredientServices;
        private IngredientServices _ingredientServicesToken;

        public Ingredient()
        {
            InitializeComponent();
            var token = ConfigurationHelper.GetTokenFromConfig();
            _ingredientServices = new IngredientServices();
            _ingredientServicesToken = new IngredientServices(token);
        }

        private void ProductIngredient_Load(object sender, EventArgs e)
        {
            ViewIngredients();
        }


        private async void ViewIngredients()
        {
            try
            {
                var ingretientsList = await _ingredientServices.GetIngredients();
                DataGridViewIngredients.DataSource = ingretientsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los ingretients: {ex.Message}");
            }
        }
    }
}
