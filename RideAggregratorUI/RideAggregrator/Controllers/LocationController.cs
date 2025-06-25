using Microsoft.AspNetCore.Mvc;
using RideAggregrator.DTO;
using System.Text.Json;

namespace RideAggregrator.Controllers
{
    public class LocationController : Controller
    {
        public  async Task<IActionResult> ViewLocations()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7035/api/");
            HttpResponseMessage msg = await client.GetAsync("Location");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var List = JsonSerializer.Deserialize<GetLocations>(RespString);
            return View(List);


            return View();
        }
    }
}
