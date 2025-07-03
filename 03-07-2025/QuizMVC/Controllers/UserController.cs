using Microsoft.AspNetCore.Mvc;
using QuizMVC.Captcha;
using QuizMVC.ClientServices;
using QuizMVC.DTO;
using System.Text.Json;

namespace QuizMVC.Controllers
{
    public class UserController : Controller
    {
        ServicesMVC clientServices;
        public UserController(ServicesMVC services)
        {
            clientServices = services;
        }
        [HttpGet]
        public IActionResult UserDashboard()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            // Retrieve the stored object from session
            var sessionData = HttpContext.Session.GetString("AccountData");

            var accountInfo = JsonSerializer.Deserialize<AccountInfoDTO>(sessionData);

            var user = await clientServices.GetUserById(accountInfo.accountId);

            if (user == null)
            {
                return NotFound();
            }

            return View("Profile", user);
        }
        [HttpGet]
        public IActionResult TakeQuiz()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TakeQuiz(string catg)
        {
            var QuizList = await clientServices.GetQuizByCatg(catg);

            return View(QuizList);
        }
        
        [HttpPost]
        public async Task<IActionResult> QuizDetails(Guid id)
        {
            var QuizList = await clientServices.QuizDetailsById(id);
            return View("QuizDetails", QuizList);
        }
        [HttpGet]
        public IActionResult RegisterUser()
        {
            var model = new RegisterUserDTO();
            var captcha = CaptchaGenerator.GenerateCaptchaCode(); // Custom method to randomize captcha

            model.CaptchaOutput = captcha;
            TempData["CaptchaCode"] = captcha;

            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterUserDTO model)
        {
            string? serverCaptcha = TempData["CaptchaCode"]?.ToString();

            // Validate captcha first
            if (serverCaptcha == null || model.CaptchaInput != serverCaptcha)
            {
                ModelState.AddModelError("CaptchaInput", "Invalid captcha.");
                model = ResetCaptcha(model); // regenerate captcha
                return View(model);
            }

            // Validate model fields
            if (!ModelState.IsValid)
            {
                model = ResetCaptcha(model); // regenerate captcha on failed validation
                return View(model);
            }

            // Attempt user registration through client service
            bool status = await clientServices.AddUserData(model);

            if (status)
            {
                TempData["SuccessMessage"] = "Registration successful! Please log in.";
                return RedirectToAction("AccountLogin", "Account");
            }
            else
            {
                ModelState.AddModelError("", "User registration failed. Please try again.");
                model = ResetCaptcha(model); // regenerate on failure
                return View(model);
            }
        }
        private RegisterUserDTO ResetCaptcha(RegisterUserDTO model)
        {
            string newCaptcha = CaptchaGenerator.GenerateCaptchaCode(5);
            TempData["CaptchaCode"] = newCaptcha;
            model.CaptchaOutput = newCaptcha;
            model.CaptchaInput = string.Empty;
            return model;
        }
    }
}
