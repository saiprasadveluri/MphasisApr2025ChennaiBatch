using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace OnlineQuiz.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet]
        public IActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Logout")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogoutPost()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync();
            return RedirectToAction("Register", "NewCaptcha");
        }

    }
}

