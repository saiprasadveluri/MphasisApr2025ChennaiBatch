using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.DTO;
using System.Text.Json;

namespace RideAggregatorMVC.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> ViewUser()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/api/");
            HttpResponseMessage msg = await client.GetAsync("User");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetAllUsers>(respstring);
            return View(list);

        }
        public async Task<GetAllUsers> GetUsers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/api/");
            HttpResponseMessage msg = await client.GetAsync("User");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetAllUsers>(respstring);
            return list;

        }
        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> LoginVIew(string email, string password, int role)
        {
            var allusers = await GetUsers();
            var existUser = allusers?.data?.Where(u => u.uEmail == email && u.uPassword == password && u.uRole == role).FirstOrDefault();
            if (existUser != null)
            {
                HttpContext.Session.SetString("email", existUser.uEmail);
                return RedirectToAction("LoginVIew", "User");
            }
            ModelState.AddModelError(string.Empty, "Invalid email and Password");
            return View();
        }
    }
}
