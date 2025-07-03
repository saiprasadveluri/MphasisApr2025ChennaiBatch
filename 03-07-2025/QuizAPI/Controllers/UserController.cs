using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using QuizAPI.DTO;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public ServicesAPI services;
        public UserController(ServicesAPI srv) 
        {
            services = srv;
        }
        [HttpPost]
        public IActionResult RegisterUser(AccountUserDTO model)
        {
            bool status=services.AddUser(model);
            return Ok(status);
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var usersList=services.GetAllUsers();
            return Ok(new { data = usersList });
        }
        [HttpGet("GetQuizByCatg")]
        public IActionResult GetQuestionsByTopicId(string catg)
        {
            var quizData = services.GetQuizzesByCategory(catg);
            return Ok(new { data = quizData });
        }
        [HttpGet("GetQuizByid")]
        public IActionResult GetQuizByid([FromQuery] Guid id)
        {
            var quizData = services.GetQuizById(id);
            return Ok(new { data = quizData });
        }
        [HttpGet("GetRandomQuesByQuiz")]
        public IActionResult GetRandomQuestionsByQuiz(Guid id)
        {
            var randomQuestions = services.GetRandomQuestionsByQuiz(id);
            return Ok(new { data = randomQuestions });
        }
    }
}
