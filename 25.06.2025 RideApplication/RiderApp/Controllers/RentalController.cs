using Microsoft.AspNetCore.Mvc;
using RiderApp.DataAccess;
using RiderApp.DTO;
using System;

namespace RiderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        DbAccess Dbaccess;

        public RentalController(DbAccess dba)
        {
            Dbaccess = dba;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var records = Dbaccess.GetAllRentals();
            return Ok(new { Data = records });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            var record = Dbaccess.GetRentalById(id);
            if (record != null)
            {
                return Ok(new { Data = record });
            }
            else
            {
                return NotFound(new { Data = "Rental record not found" });
            }
        }

        [HttpPost]
        public ActionResult AddRecord(RentalDTO input)
        {
            bool status = Dbaccess.AddRental(input);
            if (status)
            {
                return Ok(new { Data = "Successfully added rental record" });
            }
            else
            {
                return BadRequest(new { Data = "Failed to add rental record" });
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateRecord(Guid id, RentalDTO updated)
        {
            if (id != updated.RentalId)
            {
                return BadRequest(new { Data = "ID mismatch" });
            }

            bool status = Dbaccess.UpdateRental(updated);
            if (status)
            {
                return Ok(new { Data = "Successfully updated rental record" });
            }
            else
            {
                return NotFound(new { Data = "Rental record not found" });
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRecord(Guid id)
        {
            bool status = Dbaccess.DeleteRentalById(id);
            if (status)
            {
                return Ok(new { Data = "Successfully deleted rental record" });
            }
            else
            {
                return NotFound(new { Data = "Rental record not found" });
            }
        }
    }
}
