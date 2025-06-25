using Microsoft.AspNetCore.Mvc;
using RideAPPMVC.Models;
using System.Net.Http;
using System.Text.Json;

namespace RideAPPMVC.Controllers
{
    public class LocationController : Controller
    {
        private readonly HttpClient _client;

        public LocationController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7153/API/");
        }

        public async Task<IActionResult> LocationView()
        {
            var msg = await _client.GetAsync("Location");
            msg.EnsureSuccessStatusCode();

            var respString = await msg.Content.ReadAsStringAsync();
            Console.WriteLine(respString);
            var lst = JsonSerializer.Deserialize<GetAllLocation>(respString);

            return View(lst?.Locations ?? new List<LocationDTO>());
        }

        //public IActionResult InsertLocation()
        //{
        //    var m = _client.GetAsync("Loca")

        //}

    }
}

