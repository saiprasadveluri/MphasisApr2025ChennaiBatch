using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Services;

namespace OnlinePharmacyAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : Controller
    {
        Unity _unity;
        public ProfileController(Unity dba)
        {
            _unity = dba;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            List<ProfileDTO> lst = _unity.ProfileService.GetAll();
            return Ok(new { Data = lst });
        }

        [HttpPost]
        public ActionResult AddUser(ProfileDTO inp)
        {
            bool Status = _unity.ProfileService.AddNewProfile(inp);
            return Ok(new { Data = "Success in Adding user" });

        }
        [HttpPut("{id}")]
        public ActionResult UpdateUser(ProfileDTO inp, int id)
        {
            inp.UserId = id;
            bool Status = _unity.ProfileService.UpdateProfile(inp);
            return Ok(new { Data = "Success in Updating user" });

        }
        [HttpDelete("{UserId}")]
        public ActionResult DeleteDiscount(int uid)
        {
            bool result = _unity.ProfileService.DeleteUser(uid);
            if (!result)
                return NotFound(new { Error = "User not found or could not be deleted" });

            return Ok(new { Data = "User deleted successfully" });
        }
    }
}
