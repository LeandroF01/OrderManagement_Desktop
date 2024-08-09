using OrderManagement_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Desktop.Services
{
    internal class AddresseServices
    {
        private readonly HttpClient _httpClient;

        public AddresseServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5287/api/");
        }

        public async Task<List<Addresses>> GetAddresses()
        {
            return await _httpClient.GetFromJsonAsync<List<Addresses>>("Addresses");
        }

        public async Task<Addresses> GetAddresById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Addresses>($"Addresses/{id}");
        }

        public async Task<bool> AddAddres(Addresses addresses)
        {
            var response = await _httpClient.PostAsJsonAsync("Addresses", addresses);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAddres(Addresses addresses)
        {
            var response = await _httpClient.PutAsJsonAsync($"Addresses/{addresses.AddressID}", addresses);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAddres(int id)
        {
            var response = await _httpClient.DeleteAsync($"Addresses/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
