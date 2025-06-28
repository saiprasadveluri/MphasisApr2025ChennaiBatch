using Microsoft.AspNetCore.Mvc;
using OnlineQuiz.Data;

namespace OnlineQuiz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            string storedCaptcha = HttpContext.Session.GetString("CaptchaCode");

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (storedCaptcha == null || model.CaptchaInput?.ToLower() != storedCaptcha.ToLower())
            {
                ModelState.AddModelError("CaptchaInput", "Invalid captcha code.");
                return View(model);
            }

            // Registration logic here (save user to DB, etc.)
            // Redirect to success or login page
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View(); // Create a Success.cshtml if needed
        }
    }
}
