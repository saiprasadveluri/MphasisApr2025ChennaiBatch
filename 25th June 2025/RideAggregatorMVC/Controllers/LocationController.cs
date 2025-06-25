using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.DTO;
using System.Text.Json;

namespace RideAggregatorMVC.Controllers
{
    public class LocationController : Controller
    {
        public async Task<IActionResult> LocationView()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/api/");
            HttpResponseMessage msg = await client.GetAsync("Location");
            msg.EnsureSuccessStatusCode();
            string responseStr = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetAllLocations>(responseStr);
            return View(list);
        }
    }
}
