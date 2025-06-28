using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyApp.DTO;
using OnlinePharmacyApp.Models;
using System.Text.Json;

namespace OnlinePharmacyApp.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> ViewUser()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7213/api");

                HttpResponseMessage response = await client.GetAsync("User"); // Adjusted endpoint to /api/User
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                var users = JsonSerializer.Deserialize<List<GetUsers>>(json); // Replace 'User' with your actual model

                return View(User); // Returns to a Razor view like ViewUsers.cshtml
            }
        }
    }

}