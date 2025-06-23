using RideAggregatorMVC.Models;

namespace RideAggregatorMVC.Services
{
    public class CustomerService
    {
        private readonly HttpClient _http;
        public CustomerService(HttpClient http) => _http = http;

        public async Task<List<Customer>> GetAllAsync()
        {
            var response = await _http.GetAsync("https://localhost:5001/api/Customer");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Customer>>() ?? new();
        }

        public async Task CreateAsync(Customer customer)
        {
            var response = await _http.PostAsJsonAsync("https://localhost:7184/api/Customer", customer);
            response.EnsureSuccessStatusCode();
        }
    }
}

