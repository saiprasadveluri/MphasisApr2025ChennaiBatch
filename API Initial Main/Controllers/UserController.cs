using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Services;

namespace OnlinePharmacyAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
       Unity _unity;
        public UserController(Unity dba)
        {
            _unity = dba;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            List<UserDTO> lst = _unity.UserService.GetAllUsers();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var user = _unity.UserService.GetUserById(id);

            if (user == null)
            {
                return NotFound(new { Message = $"User with ID {id} not found." });
            }

            return Ok(user);
        }

        [HttpPost]
        public ActionResult AddUser(UserDTO inp)
        {
            bool Status = _unity.UserService.AddNewUser(inp);
            return Ok(new { Data = "Success in Adding User" });

        }
        [HttpPut("{id}")]
        public ActionResult UpdateUser(UserDTO inp,int id)
        {
            inp.UserId = id;
            bool Status = _unity.UserService.UpdateUser(inp);
            return Ok(new { Data = "Success in Updating User" });

            ///----------------------------
            Console.WriteLine($"API received update for user: {id}");

        }
        [HttpDelete("{userId}")]
        public ActionResult DeleteUser(int userId)
        {
            bool result = _unity.UserService.DeleteUser(userId);
            if (!result)
                return NotFound(new { Error = "User not found or could not be deleted" });

            return Ok(new { Data = "User deleted successfully" });
        }
        [HttpGet("Authenticate")]
        public ActionResult<UserDTO> Authenticate([FromQuery] string email, [FromQuery] string password)
        {
            var user = _unity.UserService.AuthenticateUser(email, password);

            if (user == null)
                return Unauthorized(new { Message = "Invalid email or password" });

            return Ok(user);
        }
    }
}
