using Microsoft.AspNetCore.Mvc;
using RideAggregatorCore.Drivers.models;
using RideAggregatorCore.LoginForm.Services;

namespace RideAggregatorCore.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly ApiClient _api;

        public AuthController(ApiClient api)
        {
            _api = api;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var users = await _api.GetAsync<List<UserDatas>("AppUser");

            var match = users?.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
            if (match != null)
            {
                HttpContext.Session.SetInt32("UserId", match.AppUserId);
                TempData["Username"] = model.Username;
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid login!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
