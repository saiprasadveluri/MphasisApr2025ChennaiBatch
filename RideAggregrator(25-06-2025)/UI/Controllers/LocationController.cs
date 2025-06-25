using Microsoft.AspNetCore.Mvc;
using RideAggeratorUI.DTO;
using System.Text.Json;

namespace RideAggeratorUI.Controllers
{
    public class LocationController : Controller
    {
        public async Task<IActionResult> Viewlocations()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7210/api/");
            HttpResponseMessage msg = await client.GetAsync("Location");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetLocation>(RespString);
            return View(list);
        }
    }
}
