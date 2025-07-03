using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using OnlineQuizMVC.Captcha;
using OnlineQuizMVC.ClientServices;
using OnlineQuizMVC.DTO;
using System.Text.Json;

namespace OnlineQuizMVC.Controllers
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
        [HttpPost]
        public async Task<IActionResult> QuizDetails(Guid id)
        {
            var QuizList = await clientServices.QuizDetailsById(id);
            return View("QuizDetails", QuizList);
        }
        [HttpGet]
        public IActionResult Quiz()
        {            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Quiz(string catg)
        {
            var QuizList = await clientServices.GetQuizByCatg(catg);

            return View(QuizList);
        }


        //[HttpPost]
        //public async Task<IActionResult> StartQuiz(Guid id)
        //{
        //    var QuizList = await clientServices.QuizDetailsById(id);

        //    return View("StartQuiz", QuizList.quizId);
        //}
        [HttpPost]
        public async Task<IActionResult> StartQuiz(Guid id)
        {
            
            var questions = await clientServices.GetQuesByRandm(id);
            string qId = id.ToString();
            HttpContext.Session.SetString("QuizId", qId);

            // ✅ Store questions and index in session
            HttpContext.Session.SetString("QuizData", JsonSerializer.Serialize(questions));
            HttpContext.Session.SetInt32("CurrentIndex", 0);

            // ✅ Initialize empty answer tracking dictionary
            var emptyAnswers = new Dictionary<Guid, Guid>();
            HttpContext.Session.SetString("Answers", JsonSerializer.Serialize(emptyAnswers));

            ViewBag.CurrentIndex = 0;
            ViewBag.TotalQuestions = questions.Count;
            ViewBag.Answers = emptyAnswers;

            return View("StartQuiz", questions[0]);
        }

        [HttpPost]
        public IActionResult SubmitAnswer(Guid QuestionId, Guid? SelectedOptionId, int CurrentIndex, string actionType)
        {
            // ✅ Load questions and answers from session
            var quizJson = HttpContext.Session.GetString("QuizData");
            var answerJson = HttpContext.Session.GetString("Answers");

            if (string.IsNullOrEmpty(quizJson))
                return RedirectToAction("StartQuiz");

            var questions = JsonSerializer.Deserialize<List<GetQuestionWithOptionsDTO>>(quizJson);
            var answers = string.IsNullOrEmpty(answerJson)
                ? new Dictionary<Guid, Guid>()
                : JsonSerializer.Deserialize<Dictionary<Guid, Guid>>(answerJson);

            // ✅ Save current selection (if present)
            if (SelectedOptionId.HasValue)
            {
                answers[QuestionId] = SelectedOptionId.Value;
                HttpContext.Session.SetString("Answers", JsonSerializer.Serialize(answers));
            }

            // ✅ Navigation logic
            if (actionType == "prev" && CurrentIndex > 0)
            {
                CurrentIndex--;
            }
            else if (actionType == "next" && CurrentIndex < questions.Count - 1)
            {
                CurrentIndex++;
            }
            else if (actionType == "submit")
            {
                return RedirectToAction("QuizSummary");
            }

            // ✅ Persist navigation state
            HttpContext.Session.SetInt32("CurrentIndex", CurrentIndex);
            ViewBag.CurrentIndex = CurrentIndex;
            ViewBag.TotalQuestions = questions.Count;
            ViewBag.Answers = answers;

            var currentQuestion = questions[CurrentIndex];
            return View("StartQuiz", currentQuestion);
        }

        public async Task<IActionResult> QuizSummary()
        {
            var answersJson = HttpContext.Session.GetString("Answers");
            var questionsJson = HttpContext.Session.GetString("QuizData");
            var sessionData = HttpContext.Session.GetString("AccountData");
            var QuizId = HttpContext.Session.GetString("QuizId");

            if (string.IsNullOrEmpty(answersJson) || string.IsNullOrEmpty(questionsJson))
                return RedirectToAction("StartQuiz");

            var questions = JsonSerializer.Deserialize<List<GetQuestionWithOptionsDTO>>(questionsJson);
            var answers = JsonSerializer.Deserialize<Dictionary<Guid, Guid>>(answersJson);
            var accountInfo = JsonSerializer.Deserialize<AccountInfoDTO>(sessionData);
            //var quizId = JsonSerializer.Deserialize<Guid>(QuizId);
            var quizId = Guid.Parse(QuizId);
            int score = 0;
            int totalQuestions = questions.Count;
            //Guid quizId = questions.FirstOrDefault()?.quizId ?? Guid.Empty;

            foreach (var question in questions)
            {
                if (answers.TryGetValue(question.questionId, out Guid selectedOptionId))
                {
                    var selectedOption = question.options.FirstOrDefault(o => o.optionId == selectedOptionId);
                    if (selectedOption != null && selectedOption.answer == 1)
                    {
                        score++;
                    }
                }
            }
            var user = await clientServices.GetUserById(accountInfo.accountId);

            var attempt = new GetQuizAttemptDTO
            {
                //attemptId = Guid.NewGuid(),
                userId = user.userId,
                quizId = quizId,
                attemptTime = DateTime.UtcNow,
                score = score,
                status = "completed"
            };
            
            // ✅ Save the attempt using your service
            await clientServices.SaveQuizAttempt(attempt);

            ViewBag.Score = score;
            ViewBag.TotalQuestions = totalQuestions;
            ViewBag.Answers = answers;

            return View("QuizSummary", questions);
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
        //[HttpPost]
        //public async Task<IActionResult> StartQuiz(Guid id)
        //{
        //    var quizQuestions = await clientServices.GetQuesRand(id);
        //    return View(quizQuestions);
        //}

        //public async Task<IActionResult> StartQuiz(Guid id)
        //{
        //    var quizQuestions = await clientServices.GetQuesRand(id);

        //    //if (quizQuestions == null || !quizQuestions.Any())
        //    //{
        //    //    // Redirect or show error view if no questions are returned
        //    //    TempData["Message"] = "No questions available for this quiz.";
        //    //    return RedirectToAction("Index"); // or wherever your quiz list is
        //    //}

        //    var model = new QuizSessionViewModel
        //    {
        //        QuizId = id,
        //        Questions = quizQuestions,
        //        CurrentIndex = 0,
        //        SelectedAnswers = new Dictionary<Guid, Guid>()
        //    };

        //    TempData["Questions"] = quizQuestions;
        //    TempData["Answers"] = model.SelectedAnswers;
        //    TempData.Keep(); // persists across multiple requests

        //    return View("StartQuiz", model);
        //}



        //[HttpGet]
        //public IActionResult TakeQuiz()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> TakeQuiz(string catg)
        //{
        //    var QuizList = await clientServices.GetQuizByCatg(catg);

        //    return View(QuizList);
        //}



        //[HttpPost]
        //public IActionResult SubmitAnswer(Guid quizId, Guid questionId, Guid selectedOptionId, int nextIndex)
        //{
        //    var answers = TempData["Answers"] as Dictionary<Guid, Guid> ?? new Dictionary<Guid, Guid>();
        //    var questions = TempData["Questions"] as List<GetQuestionWithOptionsDTO>;

        //    answers[questionId] = selectedOptionId;

        //    TempData["Answers"] = answers;
        //    TempData["Questions"] = questions;
        //    TempData.Keep();

        //    var model = new QuizSessionViewModel
        //    {
        //        QuizId = quizId,
        //        Questions = questions,
        //        CurrentIndex = nextIndex,
        //        SelectedAnswers = answers
        //    };

        //    return View("QuizFullView", model);
        //}

    }
}
