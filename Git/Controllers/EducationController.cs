using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly UnitOfWork _uow;

        public EducationController(UnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public ActionResult<IEnumerable<EducationDTO>> GetRows()
        {
            var Educations = _uow.EducationRepo.GetAll();
            return Ok(Educations);
        }

        [HttpPost]
        public ActionResult<EducationDTO> CreateRows(EducationDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _uow.EducationRepo.Insert(dto);
            _uow.Save();

            return CreatedAtAction(nameof(GetRows), new { id = dto.EducationId }, dto);
        }
        [HttpGet("{id}")]
        public ActionResult<EducationDTO> GetFromId(Guid id)
        {
            var Education = _uow.EducationRepo.GetById(id);


            if (Education == null)
            {
                return NotFound($"Education with ID {id} not found.");
            }
            return Ok(Education);
        }

        [HttpPut("{id}")]
        public ActionResult<EducationDTO> UpdateRow(Guid id, EducationDTO updatedEducation)
        {
            var Educationup = _uow.EducationRepo.UpdateById(id, updatedEducation);
            _uow.Save();
            return Ok(Educationup);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRow(Guid id)
        {
            var Education = _uow.EducationRepo.DeleteById(id);
            _uow.Save();
            return Ok(Education);
        }

    }
}

