﻿using OrderManagement_Desktop.Models;
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
    internal class CategorieServices
    {
        private readonly HttpClient _httpClient;

        public CategorieServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public CategorieServices(string token)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Categories>> GetCategories()
        {
            return await _httpClient.GetFromJsonAsync<List<Categories>>("Categories");
        }

        public async Task<Categories> GetCategorieById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Categories>($"Categories/{id}");
        }

        public async Task<bool> AddCategorie(Categories categories)
        {
            var response = await _httpClient.PostAsJsonAsync("Categories", categories);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var addedCategories = JsonSerializer.Deserialize<Categories>(responseContent);
                categories.CategoryID = addedCategories.CategoryID;
            }
            else
            {
                MessageBox.Show($"Error: {responseContent}");
            }
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateCategorie(Categories categories)
        {
            var response = await _httpClient.PutAsJsonAsync($"Categories/{categories.CategoryID}", categories);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteCategorie(int id)
        {
            var response = await _httpClient.DeleteAsync($"Categories/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
