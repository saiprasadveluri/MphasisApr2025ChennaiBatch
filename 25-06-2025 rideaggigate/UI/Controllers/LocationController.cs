using Microsoft.AspNetCore.Mvc;
using RideAggrigateUI.DTO;
using System.Text.Json;

namespace RideAggrigateUI.Controllers
{
    public class LocationController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7165/api/");

            HttpResponseMessage msg = await client.GetAsync("Location");
            msg.EnsureSuccessStatusCode();

            string RespString = await msg.Content.ReadAsStringAsync();


            var Lst = JsonSerializer.Deserialize<GetAllLocationDataModel>(RespString);

            return View(Lst);
        }
    }
}
