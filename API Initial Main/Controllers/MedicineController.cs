using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;
using OnlinePharmacyAppAPI.Services;

namespace OnlinePharmacyAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : Controller
    {
        Unity _unity;
        public MedicineController(Unity dba)
        {
            _unity = dba;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            List<MedicineDTO> lst = _unity.MedicineService.GetAllMedicines();
            return Ok(new { Data = lst });
        }

        [HttpPost]
        public ActionResult AddMedicine(MedicineDTO inp)
        {
            bool Status = _unity.MedicineService.AddNewMedicine(inp);
            return Ok(new { Data = "Success in Adding Medicine" });

        }
        [HttpGet("{id}")]
        public ActionResult GetMedicineById(int id)
        {
            var medicine = _unity.MedicineService.GetMedicineById(id);
            if (medicine == null)
                return NotFound(new { Error = "Medicine not found" });

            return Ok(medicine);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateMedicine(MedicineDTO inp,int id)
        {
            inp.MedicineId = id;
            bool Status = _unity.MedicineService.UpdateMedicine(inp);
            return Ok(new { Data = "Success in Updating Medicine" });

        }
        [HttpDelete("{medicineId}")]
        public ActionResult DeleteMedicine(int medicineId)
        {
            bool result = _unity.MedicineService.DeleteMedicine(medicineId);
            if (!result)
                return NotFound(new { Error = "Medicine not found or could not be deleted" });

            return Ok(new { Data = "Medicine deleted successfully" });
        }
    }
}