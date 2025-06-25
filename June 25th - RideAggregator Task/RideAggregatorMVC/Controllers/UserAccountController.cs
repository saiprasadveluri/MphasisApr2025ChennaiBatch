using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace RideAggregatorMVC.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public UserAccountController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(UserAccount user)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.PostAsJsonAsync("/api/UserAccount/Login", user);

            if (response.IsSuccessStatusCode)
            {
                TempData["Email"] = user.Email;
                return RedirectToAction("Index", "Customer");
            }

            ViewBag.Error = "Invalid credentials";
            return View();
        }

    }
}
