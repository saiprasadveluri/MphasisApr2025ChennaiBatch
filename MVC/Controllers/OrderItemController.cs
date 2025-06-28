using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyApp.Models;
using System.Text.Json;

namespace OnlinePharmacyApp.Controllers
{
//    public class OrderItemController : Controller
//    {
//        public async Task<IActionResult> ViewOrderItems()
//        {
//            using (HttpClient client = new HttpClient())
//            {
//                client.BaseAddress = new Uri("https://localhost:7213/api/");

//                HttpResponseMessage response = await client.GetAsync("OrderItem"); // Call to /api/OrderItem
//                response.EnsureSuccessStatusCode();

//                string json = await response.Content.ReadAsStringAsync();

//                var orderItems = JsonSerializer.Deserialize<List<OrderItem>>(json); // 'OrderItem' should be your model class

//                return View(orderItems); // Returns view like ViewOrderItems.cshtml
//            }
//        }
//    }
}