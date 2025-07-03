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

        [HttpGet("GetOptionsByQuestionId")]
        public async Task<IActionResult> GetOptionsByQuestionId(Guid id)
        {
            // Simulated service or data fetch (replace with your actual logic)
            var question = await services.GetQuestionWithOptionsByIdAsync(id);

            if (question == null)
            {
                return NotFound(new { message = "Question not found" });
            }

            return Ok(question);
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
        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id)
        {
            var userdata=services.GetUserById(id);
            return Ok(new {data= userdata});
        }
    }
}
