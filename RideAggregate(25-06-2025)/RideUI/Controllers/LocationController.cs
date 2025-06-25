using Microsoft.AspNetCore.Mvc;
using RideUI.DTO;
using System.Text.Json;

namespace RideUI.Controllers
{
    public class LocationController : Controller
    {
        public async Task<IActionResult> ViewLocations()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5067/api/");
            HttpResponseMessage msg = await client.GetAsync("Location");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetLocation>(RespString);
            return View(list);
        }
    }
}
