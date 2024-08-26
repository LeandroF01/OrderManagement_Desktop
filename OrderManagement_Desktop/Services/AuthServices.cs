using Microsoft.VisualBasic.ApplicationServices;
using OrderManagement_Desktop.Models;
using OrderManagement_Desktop.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Services
{
    internal class AuthServices
    {
        private readonly HttpClient _httpClient;

        public AuthServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }


        public async Task<string> Login(Models.Login login)
        {
            var response = await _httpClient.PostAsJsonAsync("auth/login", login);

            if (response.IsSuccessStatusCode)
            {
                var authResponse = await response.Content.ReadFromJsonAsync<AuthResponse>();
                ConfigurationHelper.SaveTokenToConfig(authResponse.Token);
                return authResponse?.Token;
            }

            return "Authentication failed. Please check your credentials.";

        }
    }
}
