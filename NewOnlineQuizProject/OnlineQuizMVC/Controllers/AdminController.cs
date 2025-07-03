using Microsoft.AspNetCore.Mvc;
using OnlineQuizMVC.ClientServices;
using OnlineQuizMVC.DTO;
using System.Text.Json;

namespace OnlineQuizMVC.Controllers
{
    public class AdminController : Controller
    {
       
            ServicesMVC clientServices;
       
        public AdminController(ServicesMVC services)
        {
            clientServices = services;
        }
        [HttpGet]
        public IActionResult AdminDashboard()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            // Retrieve the stored object from session
            var sessionData = HttpContext.Session.GetString("AccountData");

            var accountInfo = JsonSerializer.Deserialize<AccountInfoDTO>(sessionData);

            var admin = await clientServices.GetAdminById(accountInfo.accountId);

            if (admin == null)
            {
                return NotFound();
            }

            return View("Profile", admin);
        }
        [HttpGet]
        public IActionResult CreateQuiz()
        {
            QuizQuestionsDTO quiz = new QuizQuestionsDTO();
            return View(quiz);
        }
        [HttpPost]
        public async Task<IActionResult> CreateQuizAsync(QuizQuestionsDTO model)
        {
            bool status = await clientServices.AddQuiz(model);
            return View(model);
        }
    }
    
}
