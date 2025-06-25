using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RideAppAggMVC.Models;
using System.ComponentModel;
using System.Data;
using System.Text.Json;

namespace RideAppAggMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly HttpClient _client;

        public UserController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7064/API/");
        }
     
        public async Task<IActionResult> UserView()
        {
            // 1. Call the API
            var resp = await _client.GetAsync("User");
            resp.EnsureSuccessStatusCode();
            var json = await resp.Content.ReadAsStringAsync();

            // 2. Prepare options
            var opts = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<UserDTO> users;

            // 3a. If the API returned a raw array: [ {…}, {…} ]
            if (json.TrimStart().StartsWith("["))
            {
                users = JsonSerializer
                    .Deserialize<List<UserDTO>>(json, opts)
                    ?? new List<UserDTO>();
            }
            else
            {
                // 3b. If the API wrapped it in an object { "data": [ … ] }
                var wrapper = JsonSerializer
                    .Deserialize<GetAllUser>(json, opts);
                users = wrapper?.data ?? new List<UserDTO>();
            }

            // 4. Send to your Razor view
            return View(users);
        }

        public async Task<List<UserDTO>> GetUsers()
        {
            // 1. Call the API
            var resp = await _client.GetAsync("User");
            resp.EnsureSuccessStatusCode();
            var json = await resp.Content.ReadAsStringAsync();

            // 2. Prepare options
            var opts = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<UserDTO> users;

            // 3a. If the API returned a raw array: [ {…}, {…} ]
            if (json.TrimStart().StartsWith("["))
            {
                users = JsonSerializer
                    .Deserialize<List<UserDTO>>(json, opts)
                    ?? new List<UserDTO>();
            }
            else
            {
                // 3b. If the API wrapped it in an object { "data": [ … ] }
                var wrapper = JsonSerializer
                    .Deserialize<GetAllUser>(json, opts);
                users = wrapper?.data ?? new List<UserDTO>();
            }

            return users;
        }


        [HttpGet]
        public IActionResult LoginView() => View();

        [HttpPost]
        public async Task<IActionResult> LoginView(string email, string password)
        {
            var allusers = await GetUsers();
            var existUser = allusers.Where(u => u.email == email && u.password == password).FirstOrDefault();
            if (existUser != null)
            {
                HttpContext.Session.SetString("email", existUser.email);
                HttpContext.Session.SetString("password", existUser.password);

                if(User.IsInRole("Admin"))
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (User.IsInRole("Driver"))
                {
                    return RedirectToAction("PickupDropView", "PickupDrop");
                }
                else if (User.IsInRole("Customer"))
                {
                    return RedirectToAction("UserView", "User");
                }
               
            }
            ModelState.AddModelError(string.Empty, "Invalid email and Password");
            return View();
        }






    }
}
