using Microsoft.AspNetCore.Mvc;
using RideUI.DTO;
using System.Text.Json;

namespace RideUI.Controllers
{
    public class DriverController : Controller
    {
        public async Task<IActionResult> ViewDriver()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5067/api/");
            HttpResponseMessage msg = await client.GetAsync("Driver");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetDriver>(RespString);
            return View(list);
        }
    }
}
