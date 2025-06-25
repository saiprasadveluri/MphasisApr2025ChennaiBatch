using Microsoft.AspNetCore.Mvc;
using RideAggregateAPI.DataAccess;
using RideAggregateAPI.DTO;

namespace RideAggregateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        DBAccess Dbaccess;
        public UserController(DBAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            List<UserDTO> lst = Dbaccess.GetAllUsers();
            return Ok(new { Data = lst });
        }

        [HttpPost]
        public ActionResult AddUser(UserDTO inp)
        {
            bool Status = Dbaccess.AddNewUser(inp);
            return Ok(new { Data = "Success in Adding User" });

        }
    }
}
