using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickUpDropController : ControllerBase
    {
        DataAccess _dataAccess;
        public PickUpDropController(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        [HttpGet]
        public ActionResult<PickUpDrop> GetUsers()
        {
            List<PickUpDrop> picks = _dataAccess.GetPickUpDrops();
            return Ok(new { Data = picks });
        }

        [HttpPost]
        public ActionResult AddPicks(PickUpDrop picks)
        {
            
                if (picks != null)
                {
                    _dataAccess.AddPickUpDrops(picks);
                    return Ok(picks);
                }
                else
                {
                    return Ok("Please Add Input!!");
                }
            
        }
        [HttpPost("id")]
        public ActionResult UpdatePicks(int id, PickUpDrop picks)
        {
            try
            {
                if (picks != null && id != 0)
                {
                    _dataAccess.UpdatePickUpDrops(id, picks);
                    return Ok(picks);
                }
                else
                {
                    return Ok("Please Add Input then it will Update!!");
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
        [HttpDelete("id")]
        public ActionResult DeletePicks(int id)
        {
            try
            {
                if (id != 0)
                {
                    _dataAccess.DeletePickUpsDrops(id);
                    return Ok();
                }
                else
                {
                    return Ok("Please Provide an id then it will Delete!!");
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
