using Microsoft.AspNetCore.Mvc;

namespace OnlineQuizApp.Controllers
{
    public class QuestionBankController : Controller
    {
        public ServicesAPI services;

        public AccountController(ServicesAPI srv)
        {
            services = srv;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
