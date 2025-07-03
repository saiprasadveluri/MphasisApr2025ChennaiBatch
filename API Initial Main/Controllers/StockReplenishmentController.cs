using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Services;

namespace OnlinePharmacyAppAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class StockReplenishmentController : Controller
        {
            Unity _unity;
            public StockReplenishmentController(Unity dba)
            {
                _unity = dba;
            }
            [HttpGet]
            public ActionResult GetAll()
            {
                List<StockReplenishmentDTO> lst = _unity.StockReplenishmentService.GetAll();
                return Ok(new { Data = lst });
            }

            [HttpPost]
            public ActionResult AddStock(StockReplenishmentDTO inp)
            {
                bool Status = _unity.StockReplenishmentService.AddNewStock(inp);
                return Ok(new { Data = "Success in Adding Alternative Medicine" });

            }
            [HttpPut("{id}")]
            public ActionResult UpdateStock(StockReplenishmentDTO inp, int id)
            {
            inp.ReplenishmentId = id;
                bool Status = _unity.StockReplenishmentService.AddNewStock(inp);
                return Ok(new { Data = "Success in Updating Medicine" });

            }
            [HttpDelete("{ReplenishmentId}")]
            public ActionResult DeleteStock(int sid)
            {
                bool result = _unity.StockReplenishmentService.DeleteStock(sid);
                if (!result)
                    return NotFound(new { Error = " Medicine not found or stock could not be deleted" });

                return Ok(new { Data = "Medicine deleted successfully" });
            }
        }
}
