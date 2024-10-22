using OrderManagement_Desktop.Services;
using OrderManagement_Desktop.Utils;
using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;
using System.Text.Json;

namespace OrderManagement_Desktop.View
{
    public partial class Orders : Form
    {

        private OrderServices __ordersServices;
        private OrderServices __ordersServicesToken;
        private UserServices __userServicesToken;


        public Orders()
        {
            InitializeComponent();
            var token = ConfigurationHelper.GetTokenFromConfig();
            __ordersServices = new OrderServices();
            __ordersServicesToken = new OrderServices(token);
            __userServicesToken = new UserServices(token);
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            ViewOrders();
        }


        private async void ViewOrders()
        {
            try
            {
                // Obtener todos los pedidos desde la API
                var ordersList = await __ordersServicesToken.GetOrders();

                // Filtrar los pedidos que son de hoy y que estén pendientes
                var today = DateTime.Today;
                var pendingOrders = ordersList
                   .Where(order => order.Date.Date == today)
                    .ToList();

                // Mostrar los pedidos filtrados en formato de cards
                ViewOrderPending(pendingOrders);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los Orders: {ex.Message}");
            }
        }

        private void ViewOrderPending(List<OrderManagement_Desktop.Models.Orders> pedidos)
        {
            // Configuración del FlowLayoutPanel
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Padding = new Padding(10);

            // Limpiar el FlowLayoutPanel para no duplicar las cards
            flowLayoutPanel1.Controls.Clear();
            foreach (var pedido in pedidos)
            {
                // Crear un panel que actúe como la card
                Panel card = new Panel();
                card.Size = new Size(300, 210);
                card.BackColor = Color.Transparent;
                card.BackgroundImageLayout = ImageLayout.Stretch;

                // Crear y configurar los controles dentro de la card
                Label lblNumeroPedido = new Label();
                lblNumeroPedido.Text = "Pedido #" + pedido.OrderID;
                lblNumeroPedido.Font = new Font("Arial", 12, FontStyle.Regular);
                lblNumeroPedido.Location = new Point(10, 10);
                lblNumeroPedido.BackColor = Color.Transparent;

                Label lblCliente = new Label();
                lblCliente.Text = "Cliente ID: " + pedido.UserID;
                lblCliente.Location = new Point(10, 40);
                lblCliente.BackColor = Color.Transparent;

                Label lblTotal = new Label();
                lblTotal.Text = "Total: $" + pedido.Total.ToString("0.00");
                lblTotal.Location = new Point(10, 70);
                lblTotal.BackColor = Color.Transparent;

                // Cambiar el fondo según el estado
                switch (pedido.Status)
                {
                    case "Pending":
                        card.BackgroundImage = Image.FromFile(@"D:\Proyectos\OrderManagement_Desktop\OrderManagement_Desktop\Images\pending.png");
                        break;
                    case "In Progress":
                        card.BackgroundImage = Image.FromFile(@"D:\Proyectos\OrderManagement_Desktop\OrderManagement_Desktop\Images\progress.png");
                        break;
                    case "Completed":
                        card.BackgroundImage = Image.FromFile(@"D:\Proyectos\OrderManagement_Desktop\OrderManagement_Desktop\Images\complete.png");
                        break;
                    default:
                        //  card.BackgroundImage = Image.FromFile("ruta/a/tu/imagenPorDefecto.jpg");
                        break;
                }

                // Agregar los controles al panel (card)
                card.Controls.Add(lblNumeroPedido);
                card.Controls.Add(lblCliente);
                card.Controls.Add(lblTotal);

                card.Click += (s, e) => SelectOrder(pedido);
                // Agregar la card (panel) al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private OrderManagement_Desktop.Models.Orders selectedOrder;

        private void SelectOrder(OrderManagement_Desktop.Models.Orders pedido)
        {
            // Guardar el pedido seleccionado
            selectedOrder = pedido;
            //MessageBox.Show($"OrderID: {selectedOrder.OrderID}\n" +
            //      $"Cliente: {selectedOrder.UserID}\n" +
            //      $"Total: {selectedOrder.Total}\n" +
            //      $"Estado: {selectedOrder.Status}");
        }

        private async Task UpdateOrderStatus(string newStatus)
        {
            if (selectedOrder != null)
            {
                Users user = await __userServicesToken.GetUserById(selectedOrder.UserID);

                var orderPut = new OrderManagement_Desktop.Models.Orders
                {
                    OrderID = selectedOrder.OrderID,  
                    UserID = selectedOrder.UserID,
                    Date = selectedOrder.Date,
                    Status = newStatus,
                    OrderType = selectedOrder.OrderType,
                    Total = selectedOrder.Total,
                    Users = user
                };





                // Llamar al servicio para actualizar el pedido en la API
                var success = await __ordersServicesToken.UpdateOrder(orderPut);

                if (success)
                {
                    MessageBox.Show($"El estado del pedido ha sido actualizado a {newStatus}.");
                    ViewOrders(); // Refrescar la vista de pedidos
                }
                else
                {
                    MessageBox.Show("Error al actualizar el estado del pedido.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún pedido.");
            }
        }

        private async void ButtonPending_Click(object sender, EventArgs e)
        {
            await UpdateOrderStatus("Pending");
        }

        private async void ButtonProgress_Click(object sender, EventArgs e)
        {
            await UpdateOrderStatus("In Progress");
        }

        private async void ButtonCompleted_Click(object sender, EventArgs e)
        {
            await UpdateOrderStatus("Completed");
        }
    }
}