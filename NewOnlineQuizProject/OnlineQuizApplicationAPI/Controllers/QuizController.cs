using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineQuizApplicationAPI.DTO;
using OnlineQuizApplicationAPI.Services;

namespace OnlineQuizApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        public QuizServices qServices;
        public QuizController(QuizServices services)
        {
            qServices = services;
        }
        [HttpPost]
        public async Task<IActionResult> AddAttempt([FromBody] QuizAttemptDTO dto)
        {
            var attemptId = await qServices.AddQuizAttemptAsync(dto);
            return Ok(new { AttemptId = attemptId });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttempt(Guid id)
        {
            var attempt = await qServices.GetQuizAttemptByIdAsync(id);
            if (attempt == null) return NotFound();
            return Ok(attempt);
        }

        //[HttpGet("user/{userId}")]
        //public async Task<IActionResult> GetUserAttempts(Guid userId)
        //{
        //    var attempts = await qServices.GetAttemptsByUserAsync(userId);
        //    return Ok(attempts);
        //}
    }
}
