using Microsoft.AspNetCore.Mvc;

namespace OnlineQuizMVC.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
