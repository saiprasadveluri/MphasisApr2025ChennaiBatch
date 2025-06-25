using Microsoft.AspNetCore.Mvc;
using RideAggregateMVCAPI.DTO;
using System.Text.Json;

namespace RideAggregateMVCAPI.Controllers
{
    public class LocationController : Controller
    {
        public async Task<IActionResult> ViewLocations()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            HttpResponseMessage msg = await client.GetAsync("Location");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetAllLocations>(respstring);
            return View(list);

        }
    }
}
