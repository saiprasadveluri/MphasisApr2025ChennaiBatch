using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppMVC.DTO;
using System.Text.Json;

namespace OnlinePharmacyAppMVC.Controllers
{
    public class OrderItemController : Controller
    {
        public async Task<IActionResult> ViewOrderItem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7269/api/");
            HttpResponseMessage msg = await client.GetAsync("OrderItem");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetOrderItem>(respstring);
            return View(list);

        }
    }
}
