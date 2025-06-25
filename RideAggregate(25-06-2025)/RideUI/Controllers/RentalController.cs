using Microsoft.AspNetCore.Mvc;
using RideUI.DTO;
using System.Text.Json;

namespace RideUI.Controllers
{
    public class RentalController : Controller
    {
        public async Task<IActionResult> ViewRent()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5067/api/");
            HttpResponseMessage msg = await client.GetAsync("RentalRide");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetRent>(RespString);
            return View(list);
        }
    }
}
