using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RideAggregatorMVC.Models;
using RideAggregatorMVC.Services;
using System.Net.Http.Json;
using System.Threading.Tasks;

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
            var response = await client.PostAsJsonAsync("https://localhost:7184/api/Account/Login", user);

            if (response.IsSuccessStatusCode)
            {
                var loginResult = await response.Content.ReadFromJsonAsync<AuthResponse>();

                if (loginResult is not null)
                {
                    HttpContext.Session.SetString("AuthToken", loginResult.Token);
                    HttpContext.Session.SetString("UserRole", loginResult.Role);

                    if (loginResult.Role == "Admin")
                        return RedirectToAction("Dashboard", "Admin");

                    if (loginResult.Role == "Customer")
                    {
                        HttpContext.Session.SetString("CustomerId", loginResult.Id.ToString());
                        return RedirectToAction("BookRide", "Ride");
                    }
                }
            }

            ViewBag.Message = "Invalid credentials.";
            return View();
        }

        [HttpGet]
        public IActionResult DriverLogin() => View();

        [HttpPost]
        public async Task<IActionResult> DriverLogin(UserLogin login)
        {
            var client = _clientFactory.CreateClient();
            var response = await client.PostAsJsonAsync("https://localhost:7184/api/Account/Login", login);

            if (response.IsSuccessStatusCode)
            {
                var loginResult = await response.Content.ReadFromJsonAsync<AuthResponse>();

                if (loginResult is not null && loginResult.Role == "Driver")
                {
                    HttpContext.Session.SetString("DriverId", loginResult.Id.ToString());
                    HttpContext.Session.SetString("UserRole", "Driver");
                    HttpContext.Session.SetString("AuthToken", loginResult.Token);

                    return RedirectToAction("DriverDashboard", "Ride");
                }
            }

            ViewBag.Error = "Invalid login or not a driver.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
