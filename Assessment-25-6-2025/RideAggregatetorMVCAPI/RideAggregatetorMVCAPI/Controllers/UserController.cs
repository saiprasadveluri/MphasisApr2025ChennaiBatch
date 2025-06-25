using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatetorMVCAPI.DataAccess;
using RideAggregatetorMVCAPI.DataDTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RideAggregatetorMVCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DataAccessLayer data;
        public UserController(DataAccessLayer dbaccess)
        {
            data = dbaccess;
        }
        [HttpPost]
        public ActionResult AddUser(UserDTO inp)
        {
            bool Status = data.AddUser(inp);
            return Ok(new { Data = "Success in Adding user" });
        }
        [HttpGet]
        public ActionResult GetAllUsers()
        {
            List<UserDTO> lst = data.GetAllUsers();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            UserDTO obj = data.GetUserById(id);
            if (obj != null)
            {
                return Ok(new { Data = obj });
            }
            else
            {
                return NotFound(new { Data = "Error" });
            }
        }
    }
}
