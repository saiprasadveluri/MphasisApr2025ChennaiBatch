using System.Diagnostics;
using CascadeDropdownSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace CascadeDropdownSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetDpdData()
        {
            List<string> lst = new List<string>() { "sai", "durga" };
            return Json(new { url = "/Home/GetCities", data = lst });
        }
        public IActionResult GetCities()
        {
            List<string> lst = new List<string>() { "Ram", "Raheem" };
            return Json(new { url = "/Home/GetLocations", data = lst });
        }
        public IActionResult GetLocations()
        {
            List<string> lst = new List<string>() { "Ram", "Raheem" };
            return Json(new { url = "", data = lst });
        }
    }
}
