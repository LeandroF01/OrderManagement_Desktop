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
using OrderManagement_Desktop.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OrderManagement_Desktop.View
{
    public partial class Tables : Form

    {
        private ProductServices _productServices;
        private CategorieServices _categoriesServices;
        private OrderServices _ordersServicesToken;
        private OrderDetailServices _ordersDetailServicesToken;

        public Tables()
        {
            InitializeComponent();
            var token = ConfigurationHelper.GetTokenFromConfig();
            _productServices = new ProductServices();
            _categoriesServices = new CategorieServices();
            _ordersServicesToken = new OrderServices(token);
            _ordersDetailServicesToken = new OrderDetailServices(token);
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            ViewProducts();
            ViewCategories();
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

        private async Task ViewCategories()
        {
            try
            {
                var categoryList = await _categoriesServices.GetCategories();

                // Agregar opción "All" para mostrar todas las categorías
                categoryList.Insert(0, new Models.Categories { CategoryID = 0, Name = "All" });

                ComboBoxCategories.DisplayMember = "Name";
                ComboBoxCategories.ValueMember = "CategoryID";
                ComboBoxCategories.DataSource = categoryList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}");
            }
        }


        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en DataGridViewProductsGrid
            if (DataGridViewProductsGrid.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                var selectedRow = DataGridViewProductsGrid.SelectedRows[0];

                string productName = selectedRow.Cells["Name"].Value.ToString();
                decimal unitPrice = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                string productID = selectedRow.Cells["ProductID"].Value.ToString(); // Valor de ProductID

                // Obtener la cantidad ingresada en el TextBox
                if (int.TryParse(TextBoxCant.Text, out int quantity) && quantity > 0)
                {
                    // Calcular el total
                    decimal total = unitPrice * quantity;

                    // Agregar una nueva fila a DataGridViewAddProducts con los valores
                    DataGridViewAddProducts.Rows.Add( quantity, productName, unitPrice, total, productID);

                    // Asegurarse de que la columna ProductID esté oculta
                   // DataGridViewAddProducts.Columns["ProductID"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para agregar.");
            }
        }


        // Evento para ComboBoxCategories
        private void ComboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // Evento para TextBoxSearch (búsqueda por nombre)
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // Evento para TextBoxCod (búsqueda por código)
        private void TextBoxCod_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            // Verificar si el DataSource no es null antes de continuar
            if (DataGridViewProductsGrid.DataSource == null)
            {
                return; // Salir si el DataSource es null
            }

            // Obtener el CurrencyManager asociado al DataGridView
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[DataGridViewProductsGrid.DataSource];

            // Desactivar el CurrencyManager para evitar el error al cambiar la visibilidad de las filas
            currencyManager.SuspendBinding();

            // Obtener los valores actuales de los filtros
            string selectedCategory = ComboBoxCategories.SelectedValue?.ToString() ?? "All";
            string searchName = TextBoxSearch.Text.Trim().ToLower();
            string searchCode = TextBoxCod.Text.Trim().ToLower();

            // Filtrar los datos en el DataGridView
            foreach (DataGridViewRow row in DataGridViewProductsGrid.Rows)
            {
                // Obtener valores de la fila
                string category = row.Cells["CategoryID"].Value?.ToString();
                string name = row.Cells["Name"].Value?.ToString().ToLower() ?? "";
                string code = row.Cells["ProductID"].Value?.ToString().ToLower() ?? "";

                bool matchesCategory = selectedCategory == "0" || category == selectedCategory;
                bool matchesName = string.IsNullOrEmpty(searchName) || name.Contains(searchName);
                bool matchesCode = string.IsNullOrEmpty(searchCode) || code.Contains(searchCode);

                // Mostrar u ocultar la fila según si cumple los filtros
                row.Visible = matchesCategory && matchesName && matchesCode;
            }

            // Reanudar el CurrencyManager después de aplicar los filtros
            currencyManager.ResumeBinding();
        }



        private async void InsertOrderWithDetails()
        {
            try
            {
                // Crear una nueva instancia de Orders
                var newOrder = new Models.Orders
                {
                    UserID = 0,
                    Date = DateTime.Today,
                    Status = "Pending", // o el estado que prefieras
                    OrderType = "Dine-In", // por ejemplo, si es una orden para comer en el lugar
                    Total = CalculateTotal(), // Calcula el total de la orden
                    TableID = 0 // O el valor correspondiente
                };

                // Insertar la orden y obtener el ID generado
                int orderId = await _ordersServicesToken.AddOrder(newOrder);

                // Validar que el ID de la orden sea válido antes de continuar
                if (orderId > 0)
                {
                    // Insertar los detalles de la orden
                    foreach (DataGridViewRow row in DataGridViewAddProducts.Rows)
                    {
                        // Obtener los datos de cada producto en el DataGridViewAddProducts
                        var orderDetail = new Models.OrderDetails
                        {
                            OrderID = orderId,
                            ProductID = Convert.ToInt32(row.Cells["Product_ID"].Value),
                            Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                            UnitPrice = Convert.ToDecimal(row.Cells["Unit_Price"].Value),

                        };

                        // Llamar al servicio para agregar cada detalle de la orden
                        await _ordersDetailServicesToken.AddOrderDetail(orderDetail);
                    }

                    MessageBox.Show("Orden y detalles agregados exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al insertar la orden.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la orden con detalles: {ex.Message}");
            }
        }

        // Método auxiliar para calcular el total de la orden basado en los productos en DataGridViewAddProducts
        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in DataGridViewAddProducts.Rows)
            {
                total += Convert.ToDecimal(row.Cells["TOTAL_PRICE"].Value);
            }
            return total;
        }

        private void ButtonConfirmOrder_Click(object sender, EventArgs e)
        {
            InsertOrderWithDetails();
        }
    }
}
