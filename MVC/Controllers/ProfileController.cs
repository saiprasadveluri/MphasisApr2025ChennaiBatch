using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyApp.DTO;
using System.Text.Json;

namespace OnlinePharmacyApp.Controllers
{
    public class ProfileController : Controller
    {
        public async Task<IActionResult> ViewProfile()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7213/api");

                HttpResponseMessage response = await client.GetAsync("Profile"); // Adjusted endpoint to /api/User
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var users = JsonSerializer.Deserialize<List<GetProfile>>(json); // Replace 'User' with your actual model

                return View(Profile); // Returns to a Razor view like ViewUsers.cshtml
            }
        }
    }
}
