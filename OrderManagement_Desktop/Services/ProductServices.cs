using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
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

        public ProductServices(string token)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Products>> GetProducts()
        {

        var products = await _httpClient.GetFromJsonAsync<List<Products>>("Products");

            foreach (var product in products)
            {
                product.Stock = await CalculateAvailableStock(product.ProductID);
            }

            return products;
        }

        public async Task<Products> GetProductById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Products>($"Products/{id}");
        }

        public async Task<Products> GetProductByName(string name)
        {
            var products = await _httpClient.GetFromJsonAsync<List<Products>>("Products");
            return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<bool> AddProduct(Products product)
        {
            var response = await _httpClient.PostAsJsonAsync("Products", product);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var addedProduct = JsonSerializer.Deserialize<Products>(responseContent);
                product.ProductID = addedProduct.ProductID;
            }
            else
            {
                MessageBox.Show($"Error: {responseContent}");
            }
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
        

        //FUNTIONS
        private async Task<decimal> CalculateAvailableStock(int productId)
        {
            var productIngredientServices = new ProductIngredientServices();
            var ingredientServices = new IngredientServices();

            var allProductIngredients = await productIngredientServices.GetProductIngredients();
            var allIngredients = await ingredientServices.GetIngredients();

            var requiredIngredients = allProductIngredients.Where(pi => pi.ProductID == productId).ToList();

            if (!requiredIngredients.Any())
            {
                return 0;
            }

            decimal minStock = decimal.MaxValue;

            foreach (var pi in requiredIngredients)
            {
                var ingredient = allIngredients.FirstOrDefault(i => i.IngredientID == pi.IngredientID);
                if (ingredient != null)
                {
                    decimal availableStock = ingredient.Quantity / pi.Quantity;

                    if (availableStock < minStock)
                    {
                        minStock = availableStock;
                    }
                }
            }

            return minStock;
        }

    }
}
