using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAppAgg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DataAccess db;
        public UserController(DataAccess dataAccess)
        {
            db = dataAccess;
        }
        [HttpGet]
        public ActionResult<List<User>> GetAllUsers()
        {
            List<User> users = db.GetAllUsers();
            return Ok(users);
        }
        [HttpGet("id")]
        public ActionResult<User> GetUserById(int id)
        {
            User user = db.GetUserById(id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }
        [HttpPost]
        public ActionResult<User> AddUser(User user)
        {
            db.AddUser(user);
            return Ok(user);
        }
        [HttpPost("id")]
        public ActionResult<User> UpdateUser(int id, User user)
        {
            db.UpdateUser(id, user);
            return Ok(user);
        }
        [HttpDelete("id")]
        public ActionResult DeleteUser(int id)
        {
            db.DeleteUser(id);
            return Ok($"User with ID {id} deleted successfully.");
        }
    }
}
