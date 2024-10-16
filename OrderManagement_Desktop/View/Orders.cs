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
    public partial class Orders : Form
    {

        private OrderServices __ordersServices;
        private OrderServices __ordersServicesToken;


        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            var token = ConfigurationHelper.GetTokenFromConfig();
            __ordersServices = new OrderServices();
            __ordersServicesToken = new OrderServices(token);
        }


        private async void ViewCategories()
        {
            try
            {
                var categoriesList = await __ordersServices.GetOrders();
                DataGridViewOrders.DataSource = categoriesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
        }

            //CODIGO DE PRUEBA PARA EL USERCONTROLL

        //// En el formulario principal
        //private void CargarFormularioSecundario(Form formSecundario, TabPage tabPage)
        //{
        //    // Limpiar el TabPage si ya hay algún formulario cargado
        //    tabPage.Controls.Clear();

        //    // Configurar el formulario para que se cargue dentro del TabPage
        //    formSecundario.TopLevel = false;
        //    formSecundario.FormBorderStyle = FormBorderStyle.None; // Sin bordes
        //    formSecundario.Dock = DockStyle.Fill; // Ajustar al tamaño del TabPage
        //    tabPage.Controls.Add(formSecundario); // Agregar el formulario al TabPage
        //    tabPage.Tag = formSecundario;

        //    formSecundario.Show(); // Mostrar el formulario dentro del TabPage
        //}

        //// Evento para detectar cuando se selecciona una nueva pestaña
        //private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        //{
        //    // Verificar qué pestaña se seleccionó y cargar el formulario correspondiente
        //    if (e.TabPage == tabPage1)
        //    {
        //        Categories formProductos = new Categories(); // El formulario que quieres mostrar
        //        CargarFormularioSecundario(formProductos, tabPage1);
        //    }
        //    else if (e.TabPage == tabPage2)
        //    {
              
        //    }
        //}

    }
}