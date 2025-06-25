using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RideAggregatorMVC.Models;
using RideAggregatorMVC.Services;
using System.Net.Http.Json;

namespace RideAggregatorMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly LoginService _loginService;

        public AccountController(IHttpClientFactory clientFactory, LoginService loginService)
        {
            _clientFactory = clientFactory;
            _loginService = loginService;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(UserLogin user)
        {
            var client = _clientFactory.CreateClient();
            var response = await client.PostAsJsonAsync("https://localhost:7278/api/Account/Login", user);

            if (response.IsSuccessStatusCode)
            {
                var loginResult = await response.Content.ReadFromJsonAsync<AuthResponse>();
                HttpContext.Session.SetString("AuthToken", loginResult.Token);
                HttpContext.Session.SetString("UserRole", loginResult.Role);

                if (loginResult.Role == "Admin")
                    return RedirectToAction("Dashboard", "Admin");
                else if (loginResult.Role == "Customer")
                    return RedirectToAction("BookRide", "Ride");
            }

            ViewBag.Message = "Invalid credentials.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult DriverLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DriverLogin(UserLogin login)
        {
            var user = await _loginService.LoginAsync(login);
            if (user != null && user.Role == "Driver")
            {
                HttpContext.Session.SetString("DriverId", user.Id.ToString());
                return RedirectToAction("DriverDashboard", "Ride");
            }

            ViewBag.Error = "Invalid login or not a driver.";
            return View();
        }
    }
}
