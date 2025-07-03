using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppMVC.DTO;
using OnlinePharmacyAppMVC.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace OnlinePharmacyAppMVC.Controllers
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]


    public class HomeController : Controller
    {
        private readonly HttpClient _client;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7269/api/")
            };
        }

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var authenticatedUser = await AuthenticateUserAsync(model.Email, model.Password);

            if (authenticatedUser == null)
            {
                ViewBag.Error = "Invalid credentials";
                return View(model);
            }

            // ✅ Store unique session identifiers
            HttpContext.Session.SetString("email", authenticatedUser.email);
            HttpContext.Session.SetString("isAdmin", authenticatedUser.isAdmin.ToString());
            HttpContext.Session.SetString("userName", authenticatedUser.userName);         // optional but helpful
            HttpContext.Session.SetString("userId", authenticatedUser.userId.ToString()); // THIS is the line you're checking

            // Redirect based on role
            if (authenticatedUser.isAdmin)
                return RedirectToAction("Dashboard");
            else
                return RedirectToAction("CustomerDashboard");
        }



        public async Task<UserDTO> AuthenticateUserAsync(string email, string password)
        {
            var response = await _client.GetAsync($"User/Authenticate?email={email}&password={password}");
            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<UserDTO>();
        }




        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Dashboard()
        {
            string userId = HttpContext.Session.GetString("userId");
            string isAdmin = HttpContext.Session.GetString("isAdmin");

            if (string.IsNullOrEmpty(userId) || isAdmin != "True")
            {
                TempData["Error"] = "Access denied. Admin login required.";
                return RedirectToAction("Login");
            }

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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Profile()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login");

            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // Clears session data
            return RedirectToAction("Login"); // Redirects to login
        }




        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public async Task<IActionResult> CustomerDashboard(string? search)
        {
            // 🔐 Check session to ensure only non-admin users can access this
            string userId = HttpContext.Session.GetString("userId");
            string isAdmin = HttpContext.Session.GetString("isAdmin");

            if (string.IsNullOrEmpty(userId) || isAdmin == "True")
            {
                TempData["Error"] = "Access denied. Please log in with a customer account.";
                return RedirectToAction("Login");
            }

            try
            {
                var response = await _client.GetAsync("Medicine");
                if (!response.IsSuccessStatusCode)
                {
                    TempData["Error"] = "Failed to load medicine list.";
                    return View(new GetMedicine { data = new List<MedicineDTO>() });
                }

                var result = await response.Content.ReadFromJsonAsync<GetMedicine>();
                var medicines = result?.data ?? new List<MedicineDTO>();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    var found = medicines.FirstOrDefault(m =>
                        m.medName.Equals(search.Trim(), StringComparison.OrdinalIgnoreCase));

                    if (found != null && found.stockQty > 0)
                    {
                        return View(new GetMedicine { data = new List<MedicineDTO> { found } });
                    }

                    var alt = medicines.Where(m =>
                        found != null &&
                        m.composition == found.composition &&
                        m.stockQty > 0 &&
                        !m.medName.Equals(search.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();

                    if (!alt.Any())
                        TempData["Error"] = $"'{search}' is out of stock, and no alternatives were found.";
                    else
                        TempData["Success"] = $"'{search}' is unavailable. Showing alternatives based on composition.";

                    return View(new GetMedicine { data = alt });
                }

                return View(new GetMedicine { data = medicines });
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"An error occurred: {ex.Message}";
                return View(new GetMedicine { data = new List<MedicineDTO>() });
            }
        }








    }
}
