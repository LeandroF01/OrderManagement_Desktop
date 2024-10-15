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

        private async void AddIngredients()
        {
            var newIngredients = new Models.Ingredients
            {
                Name = TextBoxName.Text,
                Quantity = Convert.ToDecimal(TextBoxQuantity.Text),
                Unit = TextBoxUnit.Text

            };

            var json = JsonSerializer.Serialize(newIngredients);

            var result = await _ingredientServicesToken.AddIngredient(newIngredients);

            if (result)
            {
                MessageBox.Show("New Ingredients add");
            }
            else
            {
                MessageBox.Show("Error al añadir el Ingredients.");
            }

        }

        private void ButtonAddIngredient_Click(object sender, EventArgs e)
        {
            PanelAddIngredient.Visible = true;
        }

        private async void ButtonDeleteIngredient_Click(object sender, EventArgs e)
        {
            if (DataGridViewIngredients.SelectedRows.Count > 0)
            {
                // Obtener el CategoryID de la categoría seleccionada
                var selectedRow = DataGridViewIngredients.SelectedRows[0];
                var ingredientID = Convert.ToInt32(selectedRow.Cells["IngredientID"].Value);

                // Confirmar eliminación
                var confirmation = MessageBox.Show("¿Estás seguro de que quieres eliminar esta ingredient?",
                                                    "Confirmación de eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    // Intentar eliminar la categoría
                    try
                    {
                        var result = await _ingredientServicesToken.DeleteIngredient(ingredientID);

                        if (result)
                        {
                            MessageBox.Show("Ingredients eliminada exitosamente.");
                            ViewIngredients(); // Refrescar el DataGridView después de la eliminación
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la Ingredients.");
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

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            AddIngredients();
            ResetValuesTextBox();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            PanelAddIngredient.Visible = false;
            ResetValuesTextBox();
        }

        private void ResetValuesTextBox()
        {
            TextBoxName.Text = "";
            TextBoxQuantity.Text = "";
            TextBoxUnit.Text = "";
        }
    }
}
