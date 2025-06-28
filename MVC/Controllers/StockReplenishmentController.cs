using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyApp.DTO;
using System.Text.Json;

namespace OnlinePharmacyApp.Controllers
{
    public class StockReplenishmentController : Controller
    {
        public async Task<IActionResult> ViewStockReplenishment()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7213/api");

                HttpResponseMessage response = await client.GetAsync("StockReplenishment"); // Adjusted endpoint to /api/User
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var users = JsonSerializer.Deserialize<List<GetStockReplenishment>>(json); // Replace 'User' with your actual model

                return View(StockReplenishment); // Returns to a Razor view like ViewUsers.cshtml
            }
        }
    }
}
