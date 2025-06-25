using Microsoft.AspNetCore.Mvc;
using RideAppAggMVC.Models;
using System.Text.Json;

namespace RideAppAggMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly HttpClient _client;

        public CustomerController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7064/API/");
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CustomerView()
        {
            // Call the API to get pickup and drop details
            var response = await _client.GetAsync("Customer");
            response.EnsureSuccessStatusCode();

            // 2. Read JSON
            var json = await response.Content.ReadAsStringAsync();

            // 3. Deserialize directly to List<UserDTO>
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var customers = JsonSerializer
                .Deserialize<List<CustomerDTO>>(json, options)
                ?? new List<CustomerDTO>();

            // 4. Pass to the view
            return View(customers);
        }
    }
}


