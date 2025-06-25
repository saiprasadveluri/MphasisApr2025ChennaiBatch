using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccess;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        DbAccess Dbaccess;
        public AppUserController(DbAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpGet]
        public ActionResult<List<AppUserDTO>> GetAll()
        {
            return Ok(Dbaccess.GetAllAppUsers());
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            var user = Dbaccess.GetAppUserById(id);
            if (user == null) return NotFound(new { Message = "User not found" });
            return Ok(user);
        }

        [HttpPost]
        public ActionResult Add([FromBody] AppUserDTO dto)
        {
            if (dto == null) return BadRequest("Invalid data");
            Dbaccess.AddAppUser(dto);
            return Ok(new { Message = "User added successfully" });
        }

        [HttpPut("{id}")]
        public ActionResult Update(Guid id, [FromBody] AppUserDTO dto)
        {
            dto.UserId = id;
            var updated = Dbaccess.UpdateAppUser(dto);
            if (!updated) return NotFound(new { Message = "User not found" });
            return Ok(new { Message = "User updated successfully" });
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var deleted = Dbaccess.DeleteAppUser(id);
            if (!deleted) return NotFound(new { Message = "User not found" });
            return Ok(new { Message = "User deleted successfully" });
        }
    }
}
