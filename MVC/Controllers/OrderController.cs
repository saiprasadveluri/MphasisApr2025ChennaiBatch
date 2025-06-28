using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppMVC.DTO;
using System.Text.Json;

namespace OnlinePharmacyAppMVC.Controllers
{
    public class OrderController : Controller
    {
        public async Task<IActionResult> ViewOrder()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7269/api/");
            HttpResponseMessage msg = await client.GetAsync("Order");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetOrder>(respstring);
            return View(list);

        }
    }
}
