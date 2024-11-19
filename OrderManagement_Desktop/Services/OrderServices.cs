using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Services
{
    internal class OrderServices
    {
        private readonly HttpClient _httpClient;

        public OrderServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public OrderServices(string token)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Orders>> GetOrders()
        {
            return await _httpClient.GetFromJsonAsync<List<Orders>>("Orders");
        }

        public async Task<Orders> GetOrderById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Orders>($"Orders/{id}");
        }

        //public async Task<int> AddOrder(Orders orders)
        //{
        //    var response = await _httpClient.PostAsJsonAsync("Orders", orders);
        //    return response.IsSuccessStatusCode;
        //}

        public async Task<int> AddOrder(Orders order)
        {
            var response = await _httpClient.PostAsJsonAsync("Orders", order);

            if (response.IsSuccessStatusCode)
            {
                // Leer el ID generado del cuerpo de la respuesta
                var orderId = await response.Content.ReadFromJsonAsync<int>();
                return orderId;
            }

            throw new Exception("Error al crear la orden.");
        }


        public async Task<bool> UpdateOrder(Orders orders)
        {
            var response = await _httpClient.PutAsJsonAsync($"Orders/{orders.OrderID}", orders);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var statusCode = (int)response.StatusCode;  // Obtener el código de estado
                MessageBox.Show($"Error en la respuesta de la API (Código: {statusCode}): {errorContent}");
            }

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteOrder(int id)
        {
            var response = await _httpClient.DeleteAsync($"Orders/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
