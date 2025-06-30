using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationController : ControllerBase
    {
        private readonly UnitOfWork _uow;

        public JobApplicationController(UnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public ActionResult<IEnumerable<JobApplicationDTO>> GetRows()
        {
            var applications = _uow.ApplicationRepo.GetAll();
            return Ok(applications);
        }

        [HttpPost]
        public ActionResult<JobApplicationDTO> CreateRows(JobApplicationDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _uow.ApplicationRepo.Insert(dto);
            _uow.Save();

            return CreatedAtAction(nameof(GetRows), new { id = dto.ApplicationId }, dto);
        }
        [HttpGet("{id}")]
        public ActionResult<JobApplicationDTO> GetFromId(Guid id)
        {
            var application = _uow.ApplicationRepo.GetById(id);


            if (application == null)
            {
                return NotFound($"Application with ID {id} not found.");
            }
            return Ok(application);
        }

        [HttpPut("{id}")]
        public ActionResult<JobApplicationDTO> UpdateRow(Guid id, JobApplicationDTO updatedapplication)
        {
            var applicationup = _uow.ApplicationRepo.UpdateById(id, updatedapplication);
            _uow.Save();
            return Ok(applicationup);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRow(Guid id)
        {
            var application = _uow.ApplicationRepo.DeleteById(id);
            _uow.Save();
            return Ok(application);
        }
    }
}
