using Microsoft.AspNetCore.Mvc;
using RideAggregateMVCAPI.DTO;
using System.Text.Json;

namespace RideAggregateMVCAPI.Controllers
{
    public class DriverController : Controller
    {
        public async Task<IActionResult> ViewDrivers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            HttpResponseMessage msg = await client.GetAsync("Driver");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetAllDrivers>(respstring);
            return View(list);

        }
    }
}
