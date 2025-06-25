using Microsoft.AspNetCore.Mvc;
using RideAppAggMVC.Models;
using System.Text.Json;

namespace RideAppAggMVC.Controllers
{
    
    public class PickupDropController : Controller
    {
        public HttpClient _client;
        public PickupDropController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7064/API/");
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PickupDropView()
        {
            var response = await _client.GetAsync("PickupDrop");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var pickupdrops = JsonSerializer
                .Deserialize<List<PickupDropDTO>>(json, options)
                ?? new List<PickupDropDTO>();

            return View(pickupdrops);

        }
    }
}
