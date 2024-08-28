using OrderManagement_Desktop.Models;
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
    public partial class AddProducts : Form
    {

        private ProductServices _productServices;
        private ProductServices _productServicesToken;
        private ProductIngredientServices _productIngredientServices;
        private ProductIngredientServices _productIngredientServicesToken;
        private CategorieServices _categoriesServices;
        private IngredientServices _ingredientsServices;

        public AddProducts()
        {
            InitializeComponent();
            var token = ConfigurationHelper.GetTokenFromConfig();
            _productServices = new ProductServices();
            _productServicesToken = new ProductServices(token);
            _productIngredientServices = new ProductIngredientServices();
            _productIngredientServicesToken = new ProductIngredientServices(token);
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
                MessageBox.Show(ComboBoxCategories.SelectedValue.ToString());
                // Crear el producto
                //var newProduct = new Models.Products
                //{
                //    Name = TextBoxProductName.Text,
                //    Description = RichTextBoxProductDescription.Text,
                //    Price = decimal.Parse(TextBoxProductPrice.Text),
                //    CategoryID = (int)ComboBoxCategories.SelectedValue,
                //    ImageURL = ""
                //    // TextBoxImageURL.Text
                //};

                var newProduct = new Models.ProductDOT
                {
                    Name = TextBoxProductName.Text,
                    Description = RichTextBoxProductDescription.Text,
                    Price = decimal.Parse(TextBoxProductPrice.Text),
                    CategoryID = (int)ComboBoxCategories.SelectedValue,
                    ImageURL = string.IsNullOrWhiteSpace(TextBoxImageURL.Text) ? null : TextBoxImageURL.Text
                };


                var json = JsonSerializer.Serialize(newProduct);

                var result = await _productServicesToken.AddProduct(newProduct);


                if (result)
                {
                    var addedProduct = await _productServicesToken.GetProductByName(newProduct.Name);
                    int productId = addedProduct?.ProductID ?? 0;

                    MessageBox.Show(productId.ToString());

                    if (productId > 0)
                    {
                        foreach (DataGridViewRow row in DataGridViewAddIngredientes.Rows)
                        {
                            if (row.IsNewRow) continue; 

                            var ingredientName = row.Cells["IngredientName"].Value.ToString();
                            var ingredientQuantity = decimal.Parse(row.Cells["IngredientQuantity"].Value.ToString());

                            var ingredient = await _ingredientsServices.GetIngredientByName(ingredientName);

                            if (ingredient != null)
                            {
                                var productIngredient = new Models.ProductIngredientDOT
                                {
                                    ProductID = productId,
                                    IngredientID = ingredient.IngredientID,
                                    Quantity = ingredientQuantity
                                };


                                var ingredientResult = await _productIngredientServicesToken.AddProductIngredient(productIngredient);
                                if (!ingredientResult)
                                {
                                    throw new Exception($"Error al añadir el ingrediente {ingredientName} al producto.");
                                }
                            }
                        }

                        MessageBox.Show("Producto y sus ingredientes añadidos con éxito.");
                        this.Close();
                     }
                    else
                    {
                        MessageBox.Show("Error al obtener el ID del producto.");
                    }
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

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
    }
}
