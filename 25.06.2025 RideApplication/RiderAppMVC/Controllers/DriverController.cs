using Microsoft.AspNetCore.Mvc;
using RideAPPMVC.Models;
using System.Text.Json;
//using static RideAPPMVC.Models.GetAllDriver;

namespace RideAPPMVC.Controllers
{
    public class DriverController : Controller
    {
        private readonly HttpClient _client;

        public DriverController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7153/API/");
        }
        public async Task<IActionResult> DriverView()
        {
            var msg = await _client.GetAsync("Driver");
            msg.EnsureSuccessStatusCode();

            var respString = await msg.Content.ReadAsStringAsync();
            Console.WriteLine(respString);
            var lst = JsonSerializer.Deserialize<GetAllDriver>(respString);

            return View(lst?.data ?? new List<DriverDTO>());
        }

    }
}
