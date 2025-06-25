
using RideAggregatorMVC.Models;

namespace RideAggregatorMVC.Services
{
    public class LoginService
    {
        private readonly HttpClient _httpClient;

        public LoginService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7155/api/");
        }

        public async Task<AuthResponse?> LoginAsync(UserLogin login)
        {
            var response = await _httpClient.PostAsJsonAsync("Account/Login", login);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<AuthResponse>();
            }
            return null;
        }

    }
}


