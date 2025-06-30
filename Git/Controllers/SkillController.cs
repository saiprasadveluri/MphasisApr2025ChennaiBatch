using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly UnitOfWork _uow;

        public SkillController(UnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public ActionResult<IEnumerable<SkillDTO>> GetAllSkill()
        {
            var users = _uow.SkillRepo.GetAll();
            return Ok(users);
        }

        [HttpPost]
        public ActionResult<SkillDTO> CreateSkill(SkillDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _uow.SkillRepo.Insert(dto);
            _uow.Save();

            return CreatedAtAction(nameof(GetAllSkill), new { id = dto.SkillId }, dto);
        }
        [HttpGet("{id}")]
        public ActionResult<SkillDTO> ByGetId(Guid id)
        {
            var user = _uow.SkillRepo.GetById(id);


            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public ActionResult<SkillDTO> Update(Guid id, SkillDTO skillup)
        {
            var userup = _uow.SkillRepo.UpdateById(id, skillup);
            _uow.Save();
            return Ok(userup);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteSkill(Guid id)
        {
            var user = _uow.SkillRepo.DeleteById(id);
            _uow.Save();
            return Ok(user);
        }
    }
}
