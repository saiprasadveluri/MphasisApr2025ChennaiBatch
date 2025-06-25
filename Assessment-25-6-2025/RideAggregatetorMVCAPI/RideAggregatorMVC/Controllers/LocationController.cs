using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.MVCDTO;
using System.Text.Json;

namespace RideAggregatorMVC.Controllers
{
    public class LocationController : Controller
    {
        public async Task<IActionResult> ViewLocations()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214/api/");
            HttpResponseMessage msg = await client.GetAsync("Location");
            msg.EnsureSuccessStatusCode();//checking the success or not if i get 200 succes or else throw a exception
            string repstr = await msg.Content.ReadAsStringAsync();
            var l = JsonSerializer.Deserialize<GetAllLocs>(repstr);
            return View(l);
        }
    }
}
