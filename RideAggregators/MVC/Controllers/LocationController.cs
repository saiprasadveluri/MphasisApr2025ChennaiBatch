using Microsoft.AspNetCore.Mvc;
using MVC.DTO;
using System.Text.Json;

namespace MVC.Controllers
{
    public class LocationController : Controller
    {
        public async Task<IActionResult> ViewLocations()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(" https://localhost:7213/api/");
            HttpResponseMessage msg = await client.GetAsync("Location");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetLocations>(RespString);
            return View(list);
        }

    }
}
