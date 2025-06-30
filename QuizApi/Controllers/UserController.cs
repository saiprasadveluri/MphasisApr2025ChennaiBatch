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
            return Ok(new {data="user added successfully"+status});
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var usersList=services.GetAllUsers();
            return Ok(new { data = usersList });
        }
    }
}
