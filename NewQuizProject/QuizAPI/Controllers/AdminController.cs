using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizAPI.DTO;
using QuizAPI.Models;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public ServicesAPI services;
        public AdminController(ServicesAPI srv)
        {
            services = srv;
        }
        [HttpPost("addadmin")]
        public IActionResult RegisterAdmin(AccountAdminDTO adminDTO)
        {
            bool status = services.AddAdmin(adminDTO);
            return Ok(status);
        }
        [HttpGet("GetAdminById")]
        public IActionResult GetAdminById(Guid id)
        {
            var list=services.GetAdminById(id);
            return Ok(new {res=list});
        }
        [HttpPost("category")]
        public IActionResult AddCategory(CategoryWithTopicsDTO categoryWithTopicsDTO)
        {
            bool status =services.AddCategoryWithTopics(categoryWithTopicsDTO);
            return Ok(new { data="Category added successfully"+status});
        }
        [HttpPost("question")]
        public IActionResult AddQuestion(QuestionOptionsDTO questionOptionsDTO)
        {
            bool status=services.AddQuestionsWithOptions(questionOptionsDTO);
            return Ok(new {data="Question added successfully"+status });
        }
        [HttpGet("GetAllQuestions")]
        public IActionResult GetAllQuestion()
        {
            var quesList=services.GetAllQuestionsWithOptions();
            return Ok(new { data = quesList });
        }
        [HttpGet("getAllUserData")]
        public IActionResult GetAllUserData()
        {
            var allUsersData=services.GetAllUserAccounts();
            return Ok(new { data = allUsersData });
        }
        [HttpGet("getQuesByTopic")]
        public IActionResult getQuestionsByTopicId(Guid id)
        {
            var queslistBytopic = services.GetQuestionWithOptionByTopics(id);
            return Ok(new { data = queslistBytopic });
        }
        [HttpPost("AddQuiz")]
        public IActionResult AddNewQuiz(QuizQuestionsDTO quizQuestionsDTO)
        {
            bool status = services.AddQuizwithQuestionsByCategory(quizQuestionsDTO);
            return Ok(new { data = "Question added successfully" + status });
        }
        [HttpDelete("{accountId}")]
        public IActionResult DeleteUser(Guid accountId)
        {
            bool status = services.DeleteUser(accountId);
            return Ok(new { status = "Account deleted successfully "+status });
        }
        [HttpPut("UpdateAdmin/{Id}")]
        public IActionResult UpdateAdmin(Guid Id, UpdateAdminDTO adminDTO)
        {
            var adminList = services.UpdateAdmin(Id,adminDTO);
            return Ok(new { data = adminList });
        }
    }
}
