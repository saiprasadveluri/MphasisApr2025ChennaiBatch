using Microsoft.AspNetCore.Mvc;
using OnlineQuiz.Data;
using OnlineQuiz.DTO;
namespace OnlineQuiz.Controllers
{
    public class NewCaptchaController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            string code = CapchaGenarator.GenerateCaptchaCode();
            HttpContext.Session.SetString("CaptchaCode", code);
            RegisterViewModel model = new RegisterViewModel();
            model.CaptchaInput = code;
            return View(model);
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModelDTO model)
        {
            return View(model);
        }
    }
}
