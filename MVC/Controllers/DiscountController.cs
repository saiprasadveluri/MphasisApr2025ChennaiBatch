using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyApp.DTO;
using System.Text.Json;

namespace OnlinePharmacyApp.Controllers
{
    public class DiscountController : Controller
    {
        public async Task<IActionResult> ViewDiscount()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7213/api");

                HttpResponseMessage response = await client.GetAsync("Discount"); // Adjusted endpoint to /api/User
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var users = JsonSerializer.Deserialize<List<GetDiscount>>(json); // Replace 'User' with your actual model

                return View(Discount); // Returns to a Razor view like ViewUsers.cshtml
            }
        }
    }
}
