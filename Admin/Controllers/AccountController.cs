using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using JobSearchDatabase.Data;

namespace JobSearchDatabase.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public AccountController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            ViewData["HideHeader"] = true; // Use "HideNavbar" to match your layout

            var captchaCode = GenerateCaptchaCode();
            HttpContext.Session.SetString("CaptchaCode", captchaCode);
            ViewBag.CaptchaCode = captchaCode; // Show captcha code for demo

            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public async Task<IActionResult> Login(LoginView model)
        {
            ViewData["HideHeader"] = true;

            if (!ModelState.IsValid)
            {
                RegenerateCaptcha();
                return View(model);
            }

            var sessionCaptcha = HttpContext.Session.GetString("CaptchaCode");

            // Case-insensitive comparison for captcha
            if (string.IsNullOrEmpty(sessionCaptcha) ||
                string.IsNullOrEmpty(model.CaptchaCode) ||
                !model.CaptchaCode.Equals(sessionCaptcha, StringComparison.OrdinalIgnoreCase))
            {
                ModelState.AddModelError("CaptchaCode", "Invalid captcha code.");
                RegenerateCaptcha();
                return View(model);
            }

            var client = _clientFactory.CreateClient();

            var loginRequest = new
            {
                Email = model.Email,
                Password = model.Password
            };

            var content = new StringContent(JsonSerializer.Serialize(loginRequest), Encoding.UTF8, "application/json");

            // Replace with your API URL
            var response = await client.PostAsync("https://localhost:7082/api/login", content);

            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                RegenerateCaptcha();
                return View(model);
            }

            // Login successful, redirect to dashboard or home page
            return RedirectToAction("Index", "Home");
        }

        // Helper method to generate captcha
        private string GenerateCaptchaCode(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // Helper method to regenerate captcha and set ViewBag/session
        private void RegenerateCaptcha()
        {
            var newCaptcha = GenerateCaptchaCode();
            HttpContext.Session.SetString("CaptchaCode", newCaptcha);
            ViewBag.CaptchaCode = newCaptcha;
        }
    }
}
