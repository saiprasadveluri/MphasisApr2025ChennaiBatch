using RideAggregatorMVC.Models;


namespace RideAggregatorMVC.Services
{
    public class DriverService
    {
        private readonly HttpClient _http;
        public DriverService(HttpClient http) => _http = http;

        public async Task<List<Driver>> GetAllAsync()
        {
            var response = await _http.GetAsync("https://localhost:7278/api/Driver");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Driver>>() ?? new();
        }

        public async Task CreateAsync(Driver driver)
        {
            var response = await _http.PostAsJsonAsync("https://localhost:7278/api/Driver", driver);
            response.EnsureSuccessStatusCode();
        }
    }
}
