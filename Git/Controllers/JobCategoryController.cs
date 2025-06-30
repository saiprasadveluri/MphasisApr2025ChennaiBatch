using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobCategoryController : ControllerBase
    {
        private readonly UnitOfWork _uow;

        public JobCategoryController(UnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public ActionResult<IEnumerable<JobCategoryDTO>> GetRows()
        {
            var cates = _uow.CategoryRepo.GetAll();
            return Ok(cates);
        }

        [HttpPost]
        public ActionResult<JobCategoryDTO> CreateRows(JobCategoryDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _uow.CategoryRepo.Insert(dto);
            _uow.Save();

            return CreatedAtAction(nameof(GetRows), new { id = dto.CategoryId }, dto);
        }
        [HttpGet("{id}")]
        public ActionResult<JobCategoryDTO> GetFromId(Guid id)
        {
            var cate = _uow.CategoryRepo.GetById(id);
            if (cate == null)
            {
                return NotFound($"Category with ID {id} not found.");
            }
            return Ok(cate);
        }

        [HttpPut("{id}")]
        public ActionResult<JobCategoryDTO> UpdateRow(Guid id, JobCategoryDTO updatedcate)
        {
            var cateup = _uow.CategoryRepo.UpdateById(id, updatedcate);
            _uow.Save();
            return Ok(cateup);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRow(Guid id)
        {
            var cate = _uow.CategoryRepo.DeleteById(id);
            _uow.Save();
            return Ok(cate);
        }

    }
}
