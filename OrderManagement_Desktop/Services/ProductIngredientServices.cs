using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Services
{
    internal class ProductIngredientServices
    {
        private readonly HttpClient _httpClient;

        public ProductIngredientServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public ProductIngredientServices(string token)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<ProductIngredients>> GetProductIngredients()
        {
            return await _httpClient.GetFromJsonAsync<List<ProductIngredients>>("ProductIngredients");
        }

        public async Task<ProductIngredients> GetProductIngredientById(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProductIngredients>($"ProductIngredients/{id}");
        }

        public async Task<bool> AddProductIngredient(ProductIngredientDOT productIngredients)
        {
            var response = await _httpClient.PostAsJsonAsync("ProductIngredients", productIngredients);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateProductIngredient(ProductIngredients productIngredients)
        {
            var response = await _httpClient.PutAsJsonAsync($"ProductIngredients/{productIngredients.ProductIngredientID}", productIngredients);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteProductIngredient(int id)
        {
            var response = await _httpClient.DeleteAsync($"ProductIngredients/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
