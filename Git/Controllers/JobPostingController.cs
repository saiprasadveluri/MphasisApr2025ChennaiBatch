using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostingController : ControllerBase
    {

        private readonly UnitOfWork _uow;

        public JobPostingController(UnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public ActionResult<IEnumerable<JobPostingDTO>> GetRows()
        {
            var users = _uow.JobPostingRepo.GetAll();
            return Ok(users);
        }

        [HttpPost]
        public ActionResult<JobPostingDTO> CreateRows(JobPostingDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _uow.JobPostingRepo.Insert(dto);
            _uow.Save();

            return CreatedAtAction(nameof(GetRows), new { id = dto.JobPostingId }, dto);
        }
        [HttpGet("{id}")]
        public ActionResult<JobPostingDTO> GetFromId(Guid id)
        {
            var user = _uow.JobPostingRepo.GetById(id);


            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public ActionResult<JobPostingDTO> UpdateRow(Guid id, JobPostingDTO updatedUser)
        {
            var userup = _uow.JobPostingRepo.UpdateById(id, updatedUser);
            _uow.Save();
            return Ok(userup);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRow(Guid id)
        {
            var user = _uow.JobPostingRepo.DeleteById(id);
            _uow.Save();
            return Ok(user);
        }
    }
}
