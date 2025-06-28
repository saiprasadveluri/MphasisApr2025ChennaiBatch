using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppMVC.DTO;
using System.Text.Json;

namespace OnlinePharmacyAppMVC.Controllers
{
    public class StockReplenishmentController : Controller
    {
        public async Task<IActionResult> ViewStockReplenishment()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7269/api/");
            HttpResponseMessage msg = await client.GetAsync("StockReplenishment");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetStockReplenishment>(respstring);
            return View(list);

        }
    }
}
