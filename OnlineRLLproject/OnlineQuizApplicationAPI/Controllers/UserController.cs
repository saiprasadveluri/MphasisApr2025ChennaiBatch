using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineQuizApplicationAPI.DTO;
using OnlineQuizApplicationAPI.Services;

namespace OnlineQuizApplicationAPI.Controllers
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
            bool status = services.AddUser(model);
            return Ok(new { data = "user added successfully" + status });
        }
        [HttpGet("getAllUserData")]
        public IActionResult GetAllUsers()
        {
            var usersList = services.GetAllUsers();
            return Ok(new { data = usersList });
        }
        [HttpGet("getAllQuizAttempts/{id}")]
        public IActionResult GetAllQuizAttemptsById(Guid id)
        {
            var UserAttempt = services.GetAllQuizAttemptById(id);
            return Ok(new { res = UserAttempt });
        }
        [HttpGet("GetUserById")]
        public IActionResult GetUserById(Guid id)
        {
            var list = services.GetUserById(id);
            return Ok(new { res = list });
        }
        [HttpGet("GetQuizByCatg")]
        public IActionResult GetQuizByCatg(string catg)
        {
            var list = services.GetQuizzesByCategory(catg);
            return Ok(new { res = list });
        }
        [HttpPost("TakeQuizByTopics")]
        public IActionResult TakeQuizByTopics( Guid id)
        {
            bool status = services.AddQuizByTopic(id);
            return Ok(new { success = status, message = status ? "Quiz added successfully" : "Quiz creation failed" });
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

        [HttpPost("SaveQuizAttempt")]
        public async Task<ActionResult<bool>> SaveAttempt([FromBody] QuizAttemptDTO attemptDto)
        {
            bool result = await services.SaveQuizAttemptAsync(attemptDto);

            if (result)
                return Ok(true);
            else
                return BadRequest(false);
        }
    }
}
