using RideAggregatorMVC.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace RideAggregatorMVC.Services
{
    public class LocationService
    {
        private readonly HttpClient _httpClient;

        public LocationService(HttpClient client)
        {
            _httpClient = client;
            _httpClient.BaseAddress = new Uri("https://localhost:7184/api/Location");
        }

        public async Task<List<Location>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Location>>("Location");
        }

        public async Task CreateAsync(Location location)
        {
            await _httpClient.PostAsJsonAsync("Location", location);
        }
    }
}
