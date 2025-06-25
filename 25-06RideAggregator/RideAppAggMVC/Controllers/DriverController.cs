using Microsoft.AspNetCore.Mvc;
using RideAppAggMVC.Models;
using System.Text.Json;

namespace RideAppAggMVC.Controllers
{
    public class DriverController : Controller
    {
        private readonly HttpClient _client;
        public DriverController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7064/API/");
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DriverView()
        {
            var response = await _client.GetAsync("Driver");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var driver = JsonSerializer
             .Deserialize<List<DriverDTO>>(json, options)
                ?? new List<DriverDTO>();


            return View(driver);

        }
    }
}
