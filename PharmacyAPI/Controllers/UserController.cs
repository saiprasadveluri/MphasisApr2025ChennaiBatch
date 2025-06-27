using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppAPI.DataAccess;
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

        [HttpPost]
        public ActionResult AddUser(UserDTO inp)
        {
            bool Status = _unity.UserService.AddNewUser(inp);
            return Ok(new { Data = "Success in Adding User" });

        }
        [HttpPut("id")]
        public ActionResult UpdateUser(UserDTO inp)
        {
            bool Status = _unity.UserService.UpdateUser(inp);
            return Ok(new { Data = "Success in Updating User" });

        }
        [HttpDelete("{userId}")]
        public ActionResult DeleteUser(int userId)
        {
            bool result = _unity.UserService.DeleteUser(userId);
            if (!result)
                return NotFound(new { Error = "User not found or could not be deleted" });

            return Ok(new { Data = "User deleted successfully" });
        }

    }
}
