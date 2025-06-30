using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace JobSearchAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkExperienceController : ControllerBase
    {
        private readonly UnitOfWork _uow;

        public WorkExperienceController(UnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public ActionResult<IEnumerable<WorkExperienceDTO>> GetRows()
        {
            var WorkExperiences = _uow.WorkExperienceRepo.GetAll();
            return Ok(WorkExperiences);
        }

        [HttpPost]
        public ActionResult<WorkExperienceDTO> CreateRows(WorkExperienceDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _uow.WorkExperienceRepo.Insert(dto);
            _uow.Save();

            return CreatedAtAction(nameof(GetRows), new { id = dto.WorkExperienceId }, dto);
        }
        [HttpGet("{id}")]
        public ActionResult<WorkExperienceDTO> GetFromId(Guid id)
        {
            var WorkExperience = _uow.WorkExperienceRepo.GetById(id);


            if (WorkExperience == null)
            {
                return NotFound($"WorkExperience with ID {id} not found.");
            }
            return Ok(WorkExperience);
        }

        [HttpPut("{id}")]
        public ActionResult<WorkExperienceDTO> UpdateRow(Guid id, WorkExperienceDTO updatedWorkExperience)
        {
            var WorkExperienceup = _uow.WorkExperienceRepo.UpdateById(id, updatedWorkExperience);
            _uow.Save();
            return Ok(WorkExperienceup);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRow(Guid id)
        {
            var WorkExperience = _uow.WorkExperienceRepo.DeleteById(id);
            _uow.Save();
            return Ok(WorkExperience);
        }
    }

}