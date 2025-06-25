using Microsoft.AspNetCore.Mvc;
using RideUI.DTO;
using System.Text.Json;

namespace RideUI.Controllers
{
    public class PickUpRidesController : Controller
    {
        public async Task<IActionResult> ViewPickUp()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5067/api/");
            HttpResponseMessage msg = await client.GetAsync("PickUpRide");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetPickUp>(RespString);
            return View(list);
        }
    }
}
