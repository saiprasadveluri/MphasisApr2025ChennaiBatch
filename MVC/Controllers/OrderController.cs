using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyApp.Models;
using System.Text.Json;

namespace OnlinePharmacyApp.Controllers
{
    public class OrderController : Controller
    {
        public async Task<IActionResult> ViewOrders()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7213/api/");

                HttpResponseMessage response = await client.GetAsync("Order"); // Call to /api/Order
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var orders = JsonSerializer.Deserialize<List<Order>>(json); // 'Order' should be your model class

                return View(orders); // Renders a view like ViewOrders.cshtml
            }
        }
    }
}

}