using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;

        public AccountController(IHttpClientFactory factory, IConfiguration config)
        {
            _client = factory.CreateClient();
            _client.BaseAddress = new Uri(config["ApiBaseUrl"]);
            _config = config;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!await ValidateCaptchaAsync(Request.Form["g-recaptcha-response"]))
            {
                ModelState.AddModelError("", "CAPTCHA failed.");
                return View(model);
            }

            var endpoint = model.Role == "Admin" ? "api/Admin/Login" : "api/User/Login";
            var response = await _client.PostAsJsonAsync(endpoint, model);

            if (response.IsSuccessStatusCode)
            {
                TempData["Email"] = model.Email;
                TempData["Role"] = model.Role;
                return RedirectToAction("Index", model.Role); // Admin/User Index action
            }

            ModelState.AddModelError("", "Invalid credentials.");
            return View(model);
        }

        private async Task<bool> ValidateCaptchaAsync(string token)
        {
            var secret = _config["Captcha:SecretKey"];
            var result = await _client.PostAsync(
    $"https://www.google.com/recaptcha/api/siteverify?secret={secret}&response={token}",
                null);

            var json = await result.Content.ReadAsStringAsync();
            return json.Contains("\"success\": true");
        }
    }
}
