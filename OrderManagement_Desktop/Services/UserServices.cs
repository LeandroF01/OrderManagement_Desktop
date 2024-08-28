using Microsoft.VisualBasic.ApplicationServices;
using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Services
{
    internal class UserServices
    {
        private readonly HttpClient _httpClient;

        public UserServices(string token)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        public UserServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public async Task<List<Users>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<Users>>("Users");
        }

        public async Task<Users> GetUserById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Users>($"Users/{id}");
        }

        public async Task<bool> AddUser(Users user)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("Users", user);

                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error al agregar el usuario. Código: {response.StatusCode}, Mensaje: {responseContent}");
                }

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario: " + ex.Message);
            }
        }

        public async Task<bool> UpdateUser(Users user)
        {
            var response = await _httpClient.PutAsJsonAsync($"Users/{user.UserID}", user);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var response = await _httpClient.DeleteAsync($"Users/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
