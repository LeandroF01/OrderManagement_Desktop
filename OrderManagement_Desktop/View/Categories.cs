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

                var result = await __categoriesServicesToken.AddCategorie(newCategorie);
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
        private async void ButtonDeleteCategorie_Click(object sender, EventArgs e)
        {
            if (DataGridViewCategories.SelectedRows.Count > 0)
            {
                // Obtener el CategoryID de la categoría seleccionada
                var selectedRow = DataGridViewCategories.SelectedRows[0];
                var categoryId = Convert.ToInt32(selectedRow.Cells["CategoryID"].Value);

                // Confirmar eliminación
                var confirmation = MessageBox.Show("¿Estás seguro de que quieres eliminar esta categoría?",
                                                    "Confirmación de eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    // Intentar eliminar la categoría
                    try
                    {
                        var result = await __categoriesServicesToken.DeleteCategorie(categoryId);

                        if (result)
                        {
                            MessageBox.Show("Categoría eliminada exitosamente.");
                            ViewCategories(); // Refrescar el DataGridView después de la eliminación
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la categoría.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría para eliminar.");
            }
        }



        private void ButtonConfirmation_Click(object sender, EventArgs e)
        {
            AddCategorie();
        }
    }
}
