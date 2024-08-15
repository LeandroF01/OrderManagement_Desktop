using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Services
{
    internal class IngredientServices
    {
        private readonly HttpClient _httpClient;

        public IngredientServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public async Task<List<Ingredients>> GetIngredients()
        {
            return await _httpClient.GetFromJsonAsync<List<Ingredients>>("Ingredients");
        }

        public async Task<Ingredients> GetIngredientById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Ingredients>($"Ingredients/{id}");
        }

        public async Task<bool> AddIngredient(Ingredients ingredient)
        {
            var response = await _httpClient.PostAsJsonAsync("Ingredients", ingredient);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateIngredient(Ingredients ingredient)
        {
            var response = await _httpClient.PutAsJsonAsync($"Ingredients/{ingredient.IngredientID}", ingredient);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteIngredient(int id)
        {
            var response = await _httpClient.DeleteAsync($"Ingredients/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
