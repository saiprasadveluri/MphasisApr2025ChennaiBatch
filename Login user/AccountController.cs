using CaptchGenerator.Data;
using Microsoft.AspNetCore.Mvc;
using OnlineQuizApp.Data;
using OnlineQuizApp.DTO;

namespace OnlineQuizApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult AccountLogin()
        {
            string code = CaptchaGenerator.GenerateCaptchaCode(5);
            HttpContext.Session.SetString("Captchacode", code);
            var model = new RegisterViewModeldto
            {
                CaptchaOutput = code
            };
            ModelState.Clear();
            return View(model);
        }
        [HttpPost]
        public IActionResult AccountLogin(RegisterViewModeldto model)
        {
            if (!ModelState.IsValid)
            {
                string code = CaptchaGenerator.GenerateCaptchaCode(5);
                model.CaptchaOutput = code;//CaptchaGenerator.GenerateCaptchaCode(5);
                HttpContext.Session.SetString("Captchacode", code);
                model.CaptchaInput = string.Empty;
                return View(model);

            }
                string OriginalCaptcha = HttpContext.Session.GetString("Captchacode");// gets the already stored captcha in
                                                                                      // the session to the correctcaptcha
                if (model.CaptchaInput != OriginalCaptcha)
                {
                    ModelState.AddModelError("CaptchaInput", "Incorrect Captcha");//adding new error message if captcha doesnt validate 
                    string newcaptcha = CaptchaGenerator.GenerateCaptchaCode(5);
                    HttpContext.Session.SetString("Captchacode", newcaptcha);//stores the new captcha in the session as key
                                                                             //value pairs captchacode is the key
                    model.CaptchaOutput = newcaptcha;//captchainput propert in the model gets the newcaptcha code
                    model.CaptchaInput = string.Empty;

                    return View(model);
                }

            return RedirectToAction("Index", "UserDashboard");


        }
    }
}
