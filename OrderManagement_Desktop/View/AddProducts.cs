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
        }

        private async Task ViewCategories()
        {
            try
            {
                var categoryList = await _categoriesServices.GetCategories();

                ComboBoxCategories.DisplayMember = "Name"; // La propiedad que quieres mostrar.
                ComboBoxCategories.ValueMember = "CategoryID"; // El valor asociado a cada ítem.

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
                // Obtén la lista de ingredientes desde el servicio.
                var ingredientsList = await _ingredientsServices.GetIngredients();

                // Asigna la lista como el DataSource del ListBox.
                ListBoxIngredientes.DataSource = ingredientsList;

                // Especifica qué propiedad del objeto "Ingredient" se mostrará en el ListBox.
                ListBoxIngredientes.DisplayMember = "Name"; // Propiedad del modelo de ingredientes (puede ser "Name" o cualquier otra).

                // Si necesitas la ID del ingrediente para otras operaciones, puedes usar la propiedad ValueMember.
                ListBoxIngredientes.ValueMember = "IngredientID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los ingredientes: {ex.Message}");
            }
        }
    }
}
