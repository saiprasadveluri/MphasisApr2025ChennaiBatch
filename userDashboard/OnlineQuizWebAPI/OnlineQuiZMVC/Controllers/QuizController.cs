using Microsoft.AspNetCore.Mvc;
using OnlineQuiZMVC.DTO;
using OnlineQuiZMVC.Helpers;
using OnlineQuiZMVC.Models;

public class QuizController : Controller
{
    private static List<Question> questionBank = new List<Question>
    {
        new Question { Id = 1, Text = "What is HTML?", Options = new List<string>{ "Programming", "Markup", "Database", "None" } },
        new Question { Id = 2, Text = "Which language runs in browser?", Options = new List<string>{ "Java", "C#", "Python", "JavaScript" } },
        // Add more...
    };

    public ActionResult StartQuiz(int? index)
    {
        int current = index ?? 0;
        var model = new QuizSessionViewModel
        {
            Questions = questionBank,
            CurrentIndex = current,
            SelectedAnswers = TempData["Answers"] as Dictionary<int, int> ?? new Dictionary<int, int>()
        };

        TempData.Keep("Answers");
        return View(model);
    }

    [HttpPost]
    public IActionResult NextQuestion(int questionId, int optionIndex, int nextIndex)
    {
        var session = HttpContext.Session.GetObject<QuizSessionViewModel>("Quiz");

        if (session != null)
        {
            session.SelectedAnswers[questionId] = optionIndex;
            HttpContext.Session.SetObject("Quiz", session); // Save it back
        }

        return RedirectToAction("StartQuiz", new { index = nextIndex });
    }


    [HttpPost]
    public ActionResult SubmitAnswer(int questionId, int optionIndex, int nextIndex)
    {
        var answers = TempData["Answers"] as Dictionary<int, int> ?? new Dictionary<int, int>();
        answers[questionId] = optionIndex;
        TempData["Answers"] = answers;

        TempData.Keep("Answers");
        return RedirectToAction("StartQuiz", new { index = nextIndex });
    }

    public ActionResult SubmitQuiz()
    {
        var answers = TempData["Answers"] as Dictionary<int, int>;
        // Evaluate score logic...
        TempData.Clear();
        return View("QuizSummary", answers);
    }
}