using Microsoft.AspNetCore.Mvc;
using OnlineQuizApp.DTO;

namespace OnlineQuizApp.Controllers
{
    public class QuizManagerController : Controller
    {
        public IActionResult QuizList()
        {
            var sampleQuizzes = new List<QuizListDTO>
           {
             new QuizListDTO
             {
                    QuizId = Guid.NewGuid(),
                    QuizTitle = "C# Basics",
                    Category = "Programming",
                    Duration = 30
             }
        };
            return View(sampleQuizzes);
        }
        public IActionResult EditQuiz()
        {
            return View();
        }
        public IActionResult AddNewQuiz()
        {
            return View();  
        }
    }
}
