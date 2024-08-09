using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Services
{
    internal class OrderDetailServices
    {
        private readonly HttpClient _httpClient;

        public OrderDetailServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public async Task<List<OrderDetails>> GetOrderDetails()
        {
            return await _httpClient.GetFromJsonAsync<List<OrderDetails>>("OrderDetails");
        }

        public async Task<OrderDetails> GetOrderDetailById(int id)
        {
            return await _httpClient.GetFromJsonAsync<OrderDetails>($"OrderDetails/{id}");
        }

        public async Task<bool> AddOrderDetail(OrderDetails orderDetail)
        {
            var response = await _httpClient.PostAsJsonAsync("OrderDetails", orderDetail);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateOrderDetail(OrderDetails orderDetail)
        {
            var response = await _httpClient.PutAsJsonAsync($"OrderDetails/{orderDetail.OrderDetailID}", orderDetail);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteOrderDetail(int id)
        {
            var response = await _httpClient.DeleteAsync($"OrderDetails/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
