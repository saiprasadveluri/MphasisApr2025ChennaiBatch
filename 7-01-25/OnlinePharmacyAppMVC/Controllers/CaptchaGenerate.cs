using Microsoft.AspNetCore.Mvc;

namespace OnlinePharmacyAppMVC.Controllers
{
    public class CaptchaGenerate : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
