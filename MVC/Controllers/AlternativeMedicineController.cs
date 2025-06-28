using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyApp.DTO;
using System.Text.Json;

namespace OnlinePharmacyApp.Controllers
{
    public class AlternativeMedicineController : Controller
    {
        public async Task<IActionResult> ViewAlternativeMedicine()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7213/api/");

                HttpResponseMessage response = await client.GetAsync("AlternativeMedicine"); // Call to /api/Order
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var orders = JsonSerializer.Deserialize<List<AlternativeMedicine>>(json); // 'Order' should be your model class

                return View(AlternativeMedicine); // Renders a view like ViewOrders.cshtml
            }
        }
    }
}
