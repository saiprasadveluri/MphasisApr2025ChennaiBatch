using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineQuizWebAPI.ServiceAPI;
using OnlineQuizWepAPI.DTO;

namespace OnlineQuizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public ServiceApi services;
        public UserController(ServiceApi srv)
        {
            services = srv;
        }
        [HttpPost]
        public IActionResult RegisterUser(AccountUserDTO model)
        {
            bool status = services.AddUser(model);
            return Ok(new { data = "user added successfully" + status });
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var usersList = services.GetAllUsers();
            return Ok(new { data = usersList });
        }
    }
}
