using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppMVC.DTO;
using OnlinePharmacyAppMVC.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace OnlinePharmacyAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _client;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7107/api/")
            };
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        //[HttpPost]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    var authenticatedUser = await AuthenticateUserAsync(model.Email, model.Password);

        //    if (authenticatedUser == null)
        //    {
        //        ViewBag.Error = "Invalid credentials";
        //        return View(model);
        //    }

        //    // ✅ Store unique session identifiers
        //    HttpContext.Session.SetString("email", authenticatedUser.email);
        //    HttpContext.Session.SetString("isAdmin", authenticatedUser.isAdmin.ToString());
        //    HttpContext.Session.SetString("userName", authenticatedUser.userName);         // optional but helpful
        //    HttpContext.Session.SetString("userId", authenticatedUser.userId.ToString()); // THIS is the line you're checking

        //    // Redirect based on role
        //    if (authenticatedUser.isAdmin)
        //        return RedirectToAction("Dashboard");
        //    else
        //        return RedirectToAction("CustomerDashboard");
        //}



        public async Task<UserDTO> AuthenticateUserAsync(string email, string password)
        {
            var response = await _client.GetAsync($"User/Authenticate?email={email}&password={password}");
            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<UserDTO>();
        }



        [HttpGet]
        public async Task<IActionResult> CustomerDashboard()
        {
            try
            {
                var response = await _client.GetAsync("Medicine");
                if (!response.IsSuccessStatusCode)
                {
                    TempData["Error"] = "Failed to load medicine list.";
                    return View(new GetMedicine { data = new List<MedicineDTO>() });
                }

                var result = await response.Content.ReadFromJsonAsync<GetMedicine>();
                return View(result);
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Error: {ex.Message}";
                return View(new GetMedicine { data = new List<MedicineDTO>() });
            }
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }

        // Optional pages
        public IActionResult Index() => View();
        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Profile()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login");

            return View();
        }




        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            string userId = HttpContext.Session.GetString("userId");
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login");

            var response = await _client.GetAsync($"User/{userId}");
            if (!response.IsSuccessStatusCode)
                return RedirectToAction("Profile");

            var user = await response.Content.ReadFromJsonAsync<UserDTO>();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(UserDTO model)
        {
            var response = await _client.PutAsJsonAsync($"User/{model.userId}", model); // ✅ include userId in URL

            if (!response.IsSuccessStatusCode)
            {
                ViewBag.Error = "Update failed.";
                return View(model);
            }

            HttpContext.Session.SetString("userId", model.userId.ToString());
            HttpContext.Session.SetString("userName", model.userName);
            HttpContext.Session.SetString("email", model.email);

            TempData["Success"] = "Profile updated!";
            return RedirectToAction("Profile");
        }
        [HttpGet]
        public IActionResult GenerateCaptcha()
        {
            var captchaCode = Guid.NewGuid().ToString("N").Substring(0, 5);
            HttpContext.Session.SetString("CaptchaCode", captchaCode);

            var bitmap = new System.Drawing.Bitmap(100, 40);
            var graphics = System.Drawing.Graphics.FromImage(bitmap);
            graphics.Clear(System.Drawing.Color.LightGray);
            graphics.DrawString(captchaCode, new System.Drawing.Font("Arial", 18), System.Drawing.Brushes.Black, 10, 5);

            var ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return File(ms.ToArray(), "image/png");
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var sessionCaptcha = HttpContext.Session.GetString("CaptchaCode");
            if (model.CaptchaCode != sessionCaptcha)
            {
                ViewBag.Error = "Incorrect CAPTCHA code.";
                return View(model);
            }

            var authenticatedUser = await AuthenticateUserAsync(model.Email, model.Password);

            if (authenticatedUser == null)
            {
                ViewBag.Error = "Invalid credentials";
                return View(model);
            }

            // Store session data
            HttpContext.Session.SetString("email", authenticatedUser.email);
            HttpContext.Session.SetString("isAdmin", authenticatedUser.isAdmin.ToString());
            HttpContext.Session.SetString("userName", authenticatedUser.userName);
            HttpContext.Session.SetString("userId", authenticatedUser.userId.ToString());

            return authenticatedUser.isAdmin
                ? RedirectToAction("Dashboard")
                : RedirectToAction("CustomerDashboard");
        }



    }
}
