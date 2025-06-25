using Microsoft.AspNetCore.Mvc;
using RideAggrigationAPI.DataAccess;
using RideAggrigationAPI.DTO;

namespace RideAggrigationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DbAccess _db;

        public UserController(DbAccess db)
        {
            _db = db;
        }

        
        [HttpGet]
        public ActionResult GetAll()
        {
            var users = _db.GetAllUsers();
            return Ok(new { Data = users });
        }

      
        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            var user = _db.GetUserById(id);
            if (user != null)
            {
                return Ok(new { Data = user });
            }
            else
            {
                return NotFound(new { Data = "User not found" });
            }
        }


        [HttpPost]
        public ActionResult AddUser(UserAddDTO dto)
        {
            bool status = _db.AddUser(dto);
            if (status)
            {
                return Ok(new { Data = "User added successfully" });
            }
            else
            {
                return BadRequest(new { Data = "Failed to add user" });
            }
        }
    }
}
