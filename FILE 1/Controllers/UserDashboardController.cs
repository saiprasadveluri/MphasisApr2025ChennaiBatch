using Microsoft.AspNetCore.Mvc;

namespace OnlineQuizApp.Controllers
{
    public class UserDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
