using Microsoft.AspNetCore.Mvc;
using OnlineQuiZMVC.DTO;
using System.Net; 
using Microsoft.AspNetCore.Http;
using OnlineQuiZMVC.Helpers;
using OnlineQuiZMVC.Models;


public class QuizController : Controller
{
    public ActionResult TakeQuiz()

    {

        var sampleQuizzes = new List<QuizSchedule>

    {

       new QuizSchedule
{
    QuizId = Guid.NewGuid(),
    Title = "Science Basics",
    Category = "Science",
    Topic = "Physics",
    StartTime = DateTime.Now.AddMinutes(-5),   // Quiz started 5 minutes ago
    EndTime = DateTime.Now.AddMinutes(25)      // Quiz ends in 25 minutes
},

        new QuizSchedule

        {

            QuizId = Guid.NewGuid(),

            Title = "General Knowledge",

            Category = "GK",

            Topic = "Current Affairs",

            StartTime = DateTime.Today.AddHours(12),

            EndTime = DateTime.Today.AddHours(13)

        },

        new QuizSchedule

        {

            QuizId = Guid.NewGuid(),

            Title = "Mathematics Test",

            Category = "Mathematics",

            Topic = "Geometry",

            StartTime = DateTime.Today.AddHours(14),

            EndTime = DateTime.Today.AddHours(15)

        },

        new QuizSchedule

        {

            QuizId = Guid.NewGuid(),

            Title = "Programming Quiz",

            Category = "Technology",

            Topic = "C# Fundamentals",

            StartTime = DateTime.Today.AddHours(16),

            EndTime = DateTime.Today.AddHours(17)

        }

    };

        return View(sampleQuizzes);

    }

}

//    private static List<Question> questionBank = new List<Question>
//    {
//        new Question { Id = 1, Text = "What is HTML?", Options = new List<string>{ "Programming", "Markup", "Database", "None" } },
//        new Question { Id = 2, Text = "Which language runs in browser?", Options = new List<string>{ "Java", "C#", "Python", "JavaScript" } },
//         Add more...
//    };

//    public ActionResult StartQuiz(int? index)
//    {
//        int current = index ?? 0;
//        var model = new QuizSessionViewModel
//        {
//            Questions = questionBank,
//            CurrentIndex = current,
//            SelectedAnswers = TempData["Answers"] as Dictionary<int, int> ?? new Dictionary<int, int>()
//        };

//        TempData.Keep("Answers");
//        return View(model);
//    }

//    [HttpPost]
//    public IActionResult NextQuestion(int questionId, int optionIndex, int nextIndex)
//    {
//        var session = HttpContext.Session.GetObject<QuizSessionViewModel>("Quiz");

//        if (session != null)
//        {
//            session.SelectedAnswers[questionId] = optionIndex;
//            HttpContext.Session.SetObject("Quiz", session); // Save it back
//        }

//        return RedirectToAction("StartQuiz", new { index = nextIndex });
//    }


//    [HttpPost]
//    public ActionResult SubmitAnswer(int questionId, int optionIndex, int nextIndex)
//    {
//        var answers = TempData["Answers"] as Dictionary<int, int> ?? new Dictionary<int, int>();
//        answers[questionId] = optionIndex;
//        TempData["Answers"] = answers;

//        TempData.Keep("Answers");
//        return RedirectToAction("StartQuiz", new { index = nextIndex });
//    }

//    public ActionResult SubmitQuiz()
//    {
//        var answers = TempData["Answers"] as Dictionary<int, int>;
//        Evaluate score logic...
//        TempData.Clear();
//        return View("QuizSummary", answers);
//    }
//}