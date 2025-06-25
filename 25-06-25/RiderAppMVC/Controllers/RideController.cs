using Microsoft.AspNetCore.Mvc;
using RideAPPMVC.Models;
using System.Text.Json;

namespace RideAPPMVC.Controllers
{
    public class RideController : Controller
    {
        private readonly HttpClient _client;

        public RideController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7153/API/");
        }

        public async Task<IActionResult> RideView()
        {
            var msg = await _client.GetAsync("Ride");
            msg.EnsureSuccessStatusCode();

            var respString = await msg.Content.ReadAsStringAsync();
            Console.WriteLine(respString);
            var lst = JsonSerializer.Deserialize<GetAllRides>(respString);

            return View(lst?.data ?? new List<RideDTO>());
        }


    }
}
