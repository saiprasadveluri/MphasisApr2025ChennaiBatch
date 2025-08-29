
using Microsoft.AspNetCore.Mvc;
using RiderApp.DataAccess;
using RiderApp.DTO;
using System;

namespace RiderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicknDropController : ControllerBase
    {
        DbAccess Dbaccess;

        public PicknDropController(DbAccess dba)
        {
            Dbaccess = dba;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var records = Dbaccess.GetAllPicknDrop();
            return Ok(new { Data = records });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            var record = Dbaccess.GetPicknDrop(id);
            if (record != null)
            {
                return Ok(new { Data = record });
            }
            else
            {
                return NotFound(new { Data = "Pick and drop record not found" });
            }
        }

        [HttpPost]
        public ActionResult AddRecord(PicknDropDTO inp)
        {
            bool status = Dbaccess.AddPicknDrop(inp);
            if (status)
            {
                return Ok(new { Data = "Successfully added pick and drop record" });
            }
            else
            {
                return BadRequest(new { Data = "Failed to add record" });
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateRecord(Guid id, PicknDropDTO updated)
        {
            if (id != updated.RideId)
            {
                return BadRequest(new { Data = "ID mismatch" });
            }

            bool status = Dbaccess.UpdatePicknDrop(updated);
            if (status)
            {
                return Ok(new { Data = "Successfully updated record" });
            }
            else
            {
                return NotFound(new { Data = "Pick and drop record not found" });
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRecord(Guid id)
        {
            bool status = Dbaccess.DeletePicknDropById(id);
            if (status)
            {
                return Ok(new { Data = "Successfully deleted pick and drop record" });
            }
            else
            {
                return NotFound(new { Data = "Record not found" });
            }
        }
    }
}