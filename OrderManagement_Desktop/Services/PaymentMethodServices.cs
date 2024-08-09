using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Services
{
    internal class PaymentMethodServices
    {
        private readonly HttpClient _httpClient;

        public PaymentMethodServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public async Task<List<PaymentMethods>> GetPaymentMethods()
        {
            return await _httpClient.GetFromJsonAsync<List<PaymentMethods>>("PaymentMethods");
        }

        public async Task<PaymentMethods> GetPaymentMethodById(int id)
        {
            return await _httpClient.GetFromJsonAsync<PaymentMethods>($"PaymentMethods/{id}");
        }

        public async Task<bool> AddPaymentMethod(PaymentMethods paymentMethods)
        {
            var response = await _httpClient.PostAsJsonAsync("PaymentMethods", paymentMethods);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePaymentMethod(PaymentMethods paymentMethods)
        {
            var response = await _httpClient.PutAsJsonAsync($"PaymentMethods/{paymentMethods.PaymentID}", paymentMethods);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePaymentMethod(int id)
        {
            var response = await _httpClient.DeleteAsync($"PaymentMethods/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
