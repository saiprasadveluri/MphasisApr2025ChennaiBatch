using Microsoft.AspNetCore.Mvc;

namespace Book.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
