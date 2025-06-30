using Microsoft.AspNetCore.Mvc;

namespace OnlineQuiZMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
