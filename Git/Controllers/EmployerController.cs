using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly UnitOfWork _uow;
        public EmployerController(UnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public ActionResult<IEnumerable<EmployerDTO>> GetRows()
        {
            var employers = _uow.EmployerRepo.GetAll();
            return Ok(employers);
        }

        [HttpPost]
        public ActionResult<EmployerDTO> CreateRows(EmployerDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _uow.EmployerRepo.Insert(dto);
            _uow.Save();

            return CreatedAtAction(nameof(GetRows), new { id = dto.EmployerId }, dto);
        }
        [HttpGet("{id}")]
        public ActionResult<EmployerDTO> GetFromId(Guid id)
        {
            var employer = _uow.EmployerRepo.GetById(id);


            if (employer == null)
            {
                return NotFound($"Employer with ID {id} not found.");
            }
            return Ok(employer);
        }

        [HttpPut("{id}")]
        public ActionResult<EmployerDTO> UpdateRow(Guid id, EmployerDTO updatedemployer)
        {
            var employerup = _uow.EmployerRepo.UpdateById(id, updatedemployer);
            _uow.Save();
            return Ok(employerup);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRow(Guid id)
        {
            var employer = _uow.EmployerRepo.DeleteById(id);
            _uow.Save();
            return Ok(employer);
        }

    }
}
