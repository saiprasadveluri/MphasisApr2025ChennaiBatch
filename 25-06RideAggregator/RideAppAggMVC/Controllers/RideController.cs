using Microsoft.AspNetCore.Mvc;
using RideAppAggMVC.Models;
using System.Text.Json;

namespace RideAppAggMVC.Controllers
{
    public class RideController : Controller
    {
        private readonly HttpClient _client;
        public RideController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7064/API/");
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> RideView()
        {
            var response = await _client.GetAsync("Ride");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var rides = JsonSerializer
                .Deserialize<List<RideDTO>>(json, options)
                ?? new List<RideDTO>();

            return View(rides);
        }
    }
}
