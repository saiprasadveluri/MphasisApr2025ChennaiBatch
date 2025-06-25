using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccess;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DbAccess _dbAccess;
        public UserController(DbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }
        [HttpGet]
        public ActionResult<UserDTO> GetALl()
        {
            List<UserDTO> lst = _dbAccess.GetAllUsers();
            return Ok(new { Data = lst });
        }
        
        [HttpPost]
        public ActionResult AddUser(UserDTO inp)
        {
            bool Status = _dbAccess.AddUser(inp);
            return Ok(new { Data = "Success om adding User" });
        }
        [HttpPut("id")]
        public ActionResult UpdateUser(Guid id, UserDTO inp)
        {
            bool Status = _dbAccess.UpdateUser(id, inp);
            if (Status)
            {
                return Ok(new { Data = "User successfully updated" });
            }
            else
            {
                return Ok(new { Data = "Error in updating User" });
            }
        }
        [HttpDelete("id")]
        public ActionResult DeleteUser(Guid id)
        {
            bool Status = _dbAccess.DeleteUser(id);
            if (Status)
            {
                return Ok(new { Data = "User successfully deleted" });
            }
            else
            {
                return Ok(new { Data = "Error in deleting User" });
            }
        }
    }
}
