using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using OnlineQuizMVC.Captcha;
using OnlineQuizMVC.DTO;
using System.Security.Claims;
using System.Text.Json;

namespace OnlineQuizMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly HttpClient _client;

        public AccountController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7111/api/");
        }
        [HttpGet]
        public IActionResult AccountLogin()
        {
            string code = CaptchaGenerator.GenerateCaptchaCode(5);
            HttpContext.Session.SetString("Captchacode", code);

            var model = new LoginUser
            {
                CaptchaOutput = code
            };

            ModelState.Clear();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AccountLogin(LoginUser model)
        {
            if (!ModelState.IsValid)
            {
                model = ResetCaptcha(model);
                return View(model);
            }

            string sessionCaptcha = HttpContext.Session.GetString("Captchacode");

            if (model.CaptchaInput != sessionCaptcha)
            {
                ModelState.AddModelError("CaptchaInput", "Incorrect Captcha");
                model = ResetCaptcha(model);
                return View(model);
            }

            // Now authenticate from API
            GetAccountData users = await GetAccounts();
            var userWithEmail = users?.data.FirstOrDefault(u => u.email == model.email);

            if (userWithEmail == null)
            {
                ModelState.AddModelError("", "Invalid credentials");
                model = ResetCaptcha(model);
                return View(model);
            }
            if (userWithEmail.password != model.password)
            {
                ModelState.AddModelError("password", "Invalid password");
                model = ResetCaptcha(model);
                return View(model);
            }
            //var matchedUser = users?.data.FirstOrDefault(u =>
            //    u.email == model.email && u.password == model.password);

            //if (matchedUser == null)
            //{
            //    ModelState.AddModelError("", "Invalid credentials");
            //    model = ResetCaptcha(model);
            //    return View(model);
            //}
            string json = JsonSerializer.Serialize<AccountInfoDTO>(userWithEmail);
            HttpContext.Session.SetString("AccountData", json);
            await SignInUser(model.email, userWithEmail.role);
            //HttpContext.Session.SetString("AccountData", System.Text.Json.JsonSerializer.Serialize(matchedUser));

            //HttpContext.Session.SetString("AdminId", matchedUser.accountId.ToString());
            // Redirect based on role
            return userWithEmail.role switch
            {
                "Admin" => RedirectToAction("AdminDashboard", "Admin"),
                "User" => RedirectToAction("UserDashboard", "User"),
                _ => RedirectToAction("AccountLogin", "Account")
            };
        }
        private LoginUser ResetCaptcha(LoginUser model)
        {
            string newCaptcha = CaptchaGenerator.GenerateCaptchaCode(5);
            HttpContext.Session.SetString("Captchacode", newCaptcha);
            model.CaptchaOutput = newCaptcha;
            model.CaptchaInput = string.Empty;
            return model;
        }

        private async Task SignInUser(string email, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, email),
                new Claim(ClaimTypes.Role, role)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal);
        }


        [HttpGet]
        public async Task<IActionResult> ViewAccounts()
        {
            var accounts = await GetAccounts();
            return View(accounts);
        }
        public async Task<GetAccountData> GetAccounts()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("Account");
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<GetAccountData>(content);
            }
            catch
            {
                return null;
            }
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

            HttpContext.SignOutAsync();
            return RedirectToAction("AccountLogin", "Account");
        }
    }
}
