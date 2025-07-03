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
        public async Task<IActionResult> UserProfile()
        {
            // Retrieve the stored object from session
            var sessionData = HttpContext.Session.GetString("AccountData");

            var accountInfo = JsonSerializer.Deserialize<AccountInfoDTO>(sessionData);

            var user = await clientServices.GetUserById(accountInfo.accountId);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
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
        [HttpPost]
        public async Task<IActionResult> StartQuiz(Guid id)
        {
            string quizid=id.ToString();
            HttpContext.Session.SetString("QuizId", quizid);
            var start = await clientServices.GetQuesByRandm(id);
            return View("StartQuiz", start);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitAnswers(List<AnswerDTO> Answers)
        {
            int score = 0;

            var correctAnswers = await clientServices.GetCorrectAnswersForQuestions(
                Answers.Select(a => a.questionId).ToList()
            );

            foreach (var answer in Answers)
            {
                var correct = correctAnswers.FirstOrDefault(c => c.questionId == answer.questionId);
                if (correct != null && correct.optionId == answer.selectedOptionId)
                {
                    score++;
                }
            }
            var sessionData = HttpContext.Session.GetString("AccountData");

            var accountInfo = JsonSerializer.Deserialize<AccountInfoDTO>(sessionData);

            var user = await clientServices.GetUserById(accountInfo.accountId);

            // 🔐 Retrieve session data
            var quizIdString = HttpContext.Session.GetString("QuizId");

            var quizId = Guid.Parse(quizIdString);

            // 📝 Create and store the attempt
            var attempt = new QuizAttemptDTO
            {
                attemptId = Guid.NewGuid(),
                userId = user.userId,  // Adjust property name as needed
                quizId = quizId,
                attemptTime = DateTime.UtcNow,
                score = score,
                status = "Completed"
            };

            await clientServices.SaveAttempt(attempt);
            ViewBag.Score = score;
            ViewBag.Total = Answers.Count;
            return View("QuizResult", Answers);
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
                model = ResetCaptcha(model); 
                return View(model);
            }

            // Validate model fields
            if (!ModelState.IsValid)
            {
                model = ResetCaptcha(model);
                return View(model);
            }
            bool status = await clientServices.AddUserData(model);

            if (status)
            {
                TempData["SuccessMessage"] = "Registration successful! Please log in.";
                return RedirectToAction("AccountLogin", "Account");
            }
            else
            {
                ModelState.AddModelError("", "User registration failed. Please try again.");
                model = ResetCaptcha(model); 
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
