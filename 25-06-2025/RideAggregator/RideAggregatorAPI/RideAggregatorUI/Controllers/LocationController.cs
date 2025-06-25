using Microsoft.AspNetCore.Mvc;
using RideAggregatorUI.DTO;
using System.Text.Json;

namespace RideAggregatorUI.Controllers
{
    public class LocationController : Controller
    {
        public async Task<IActionResult> ViewLocations()
            {
              HttpClient client= new HttpClient();
              client.BaseAddress = new Uri("https://localhost:7058/api");
              HttpResponseMessage msg = await client.GetAsync("Location");
              msg.EnsureSuccessStatusCode();
              string RespString=await msg.Content.ReadAsStringAsync();
              var list = JsonSerializer.Deserialize<GetLocation>(RespString);
              return View(list);



             }
        
    }
}
