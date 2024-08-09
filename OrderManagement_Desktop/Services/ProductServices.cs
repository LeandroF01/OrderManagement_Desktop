using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Services
{
    internal class ProductServices
    {
        private readonly HttpClient _httpClient;

        public ProductServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public async Task<List<Products>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<List<Products>>("Products");
        }

        public async Task<Products> GetProductById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Products>($"Products/{id}");
        }

        public async Task<bool> AddProduct(Products product)
        {
            var response = await _httpClient.PostAsJsonAsync("Products", product);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateProduct(Products product)
        {
            var response = await _httpClient.PutAsJsonAsync($"Products/{product.ProductID}", product);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var response = await _httpClient.DeleteAsync($"Products/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
