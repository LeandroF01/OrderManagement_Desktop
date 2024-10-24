﻿using OrderManagement_Desktop.Models;
using OrderManagement_Desktop.View;
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
    internal class IngredientServices
    {
        private readonly HttpClient _httpClient;

        public IngredientServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public IngredientServices(string token)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Ingredients>> GetIngredients()
        {
            return await _httpClient.GetFromJsonAsync<List<Ingredients>>("Ingredients");
        }

        public async Task<Ingredients> GetIngredientById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Ingredients>($"Ingredients/{id}");
        }

        public async Task<Ingredients> GetIngredientByName(string name)
        {
            var ingredients = await GetIngredients(); 
            return ingredients.FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<bool> AddIngredient(Ingredients ingredient)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("Ingredients", ingredient);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Deserializa la respuesta si es exitosa
                    var addedCategories = JsonSerializer.Deserialize<Ingredients>(responseContent);
                    ingredient.IngredientID = addedCategories.IngredientID;
                    MessageBox.Show("Ingrediente añadido correctamente.");
                }
                else
                {
                    // Obtén más detalles del error si falla
                    MessageBox.Show($"Error: {response.StatusCode} - {responseContent}");
                }
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException ex)
            {
                // Manejo de errores relacionados con la solicitud HTTP
                MessageBox.Show($"Error de solicitud HTTP: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                MessageBox.Show($"Error general: {ex.Message}");
                return false;
            }

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
