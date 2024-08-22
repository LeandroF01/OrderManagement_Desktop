using OrderManagement_Desktop.Models;
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
    public partial class AddProducts : Form
    {

        private ProductServices _productServices;
        private ProductIngredientServices _productIngredientServices;
        private CategorieServices _categoriesServices;
        private IngredientServices _ingredientsServices;

        public AddProducts()
        {
            InitializeComponent();
            _productServices = new ProductServices();
            _productIngredientServices = new ProductIngredientServices();
            _categoriesServices = new CategorieServices();
            _ingredientsServices = new IngredientServices();
        }

        //  ListBoxIngredientes

        private async void AddProducts_Load(object sender, EventArgs e)
        {
            await ViewCategories();

            await LoadIngredients();


            DataGridViewAddIngredientes.Columns.Add("IngredientName", "Ingrediente");
            DataGridViewAddIngredientes.Columns.Add("IngredientQuantity", "Cantidad");
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

                var productIngredients = new Models.ProductIngredients
                {
                    ProductID = 0,
                    IngredientID = 0,
                    Quantity = 0,
                };

                var result = await _productServices.AddProduct(newProduct);

                if (result)
                {
                    MessageBox.Show("Producto añadido con éxito.");

                    Products productsForm = new Products();
                    productsForm.ViewProducts();
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

                    Products productsForm = new Products();
                    productsForm.ViewProducts();
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

        private async Task LoadIngredients()
        {
            try
            {
                var ingredientsList = await _ingredientsServices.GetIngredients();
                ListBoxIngredientes.DataSource = ingredientsList;

                ListBoxIngredientes.DisplayMember = "Name";

                ListBoxIngredientes.ValueMember = "IngredientID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los ingredientes: {ex.Message}");
            }
        }

        private void ButtonConfirmIngredient_Click(object sender, EventArgs e)
        {
            if (ListBoxIngredientes.SelectedItem != null && !string.IsNullOrWhiteSpace(TextBoxAmountIngredients.Text))
            {
                var selectedIngredient = (Ingredients)ListBoxIngredientes.SelectedItem;

                if (decimal.TryParse(TextBoxAmountIngredients.Text, out decimal quantity))
                {
                    DataGridViewAddIngredientes.Rows.Add(selectedIngredient.Name, quantity);
                    TextBoxAmountIngredients.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un ingrediente y especifique la cantidad.", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
