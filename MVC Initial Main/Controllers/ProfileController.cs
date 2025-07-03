using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppMVC.DTO;
using System.Text.Json;

namespace OnlinePharmacyAppMVC.Controllers
{
    public class ProfileController : Controller
    {
        public async Task<IActionResult> ViewProfile()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7269/api/");
            HttpResponseMessage msg = await client.GetAsync("Profile");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize < GetProfile>(respstring);
            return View(list);

        }
    }
}
