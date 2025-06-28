using Microsoft.AspNetCore.Mvc;

namespace OnlineQuizApp.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult RegisterLogin()
        {
            return View();
        }
    }
}
