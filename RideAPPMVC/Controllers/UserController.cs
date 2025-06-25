using Microsoft.AspNetCore.Mvc;
using RideAPPMVC.Models;
using System.Text.Json;

namespace RideAPPMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly HttpClient _client;

        public UserController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7153/API/");
        }
        public async Task<IActionResult> UserView()
        {
            var msg = await _client.GetAsync("User");
            msg.EnsureSuccessStatusCode();
            var respString = await msg.Content.ReadAsStringAsync();
            Console.WriteLine(respString);
            var lst = JsonSerializer.Deserialize<GetAllUser>(respString);
            return View(lst?.data ?? new List<UserDTO>());
        }
        public async Task<GetAllUser> GetUsers()
        {
            var msg = await _client.GetAsync("User");
            msg.EnsureSuccessStatusCode();
            var respString = await msg.Content.ReadAsStringAsync();
            Console.WriteLine(respString);
            var lst = JsonSerializer.Deserialize<GetAllUser>(respString);
            return lst;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var allusers = await GetUsers();
            var existUser = allusers?.data?.Where(u=> u.email == email && u.password == password).FirstOrDefault();
            if (existUser != null)
            {
                HttpContext.Session.SetString("email", existUser.email);
                HttpContext.Session.SetString("role", existUser.role);
                switch (existUser.role)
                {
                    case "Admin":
                        return RedirectToAction("UserView", "User");
                    case "Customer":
                        return RedirectToAction("BookRide", "PickUpDrop");
                    case "Driver":
                        return RedirectToAction("RideView", "Ride");
                    default:
                        return RedirectToAction("Login", "User");
                }
                
            }
            ModelState.AddModelError(string.Empty, "Invalid email and Password");
            return View();
        }
    }
}
