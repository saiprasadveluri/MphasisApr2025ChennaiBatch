using Microsoft.AspNetCore.Mvc;
using RideAppAggMVC.Models;
using System.Text.Json;

namespace RideAppAggMVC.Controllers
{
    public class LocationController : Controller
    {
        public readonly HttpClient _client;

        public LocationController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7064/API/");
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> LocationView()
        {
            var response = await _client.GetAsync("Location");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var locations = JsonSerializer
                .Deserialize<List<LocationDTO>>(json, options)
                ?? new List<LocationDTO>();

            return View(locations);
        }
    }
}
