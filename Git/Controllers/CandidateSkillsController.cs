using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JobSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateSkillsController : ControllerBase
    {
        private readonly JSDbContextAPI _context;
        public CandidateSkillsController(JSDbContextAPI context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<CandidateSkillsDTO> GetAll()
        {
            List<CandidateSkillsDTO> list = _context.candidateSkills.Select(x => new CandidateSkillsDTO
            {
                CandidateId = x.CandidateId,    
                SkillId = x.SkillId,
                SkillLevel = x.SkillLevel,
                IsPrimary = x.IsPrimary
            }).ToList();
            return Ok(list);
        }
        [HttpGet("{id}/{sid}")]        
        public ActionResult<CandidateSkillsDTO> GetById(Guid id, Guid sid)
        {
            var candSkill = _context.candidateSkills.Where(cs => (cs.CandidateId == id && cs.SkillId == sid)).Select(v => new CandidateSkillsDTO
            {
                CandidateId=v.CandidateId,
                SkillId=v.SkillId,
                SkillLevel = v.SkillLevel,
                IsPrimary = v.IsPrimary
            });
            return Ok(candSkill);
        }
        [HttpPost]
        public ActionResult<CandidateSkillsDTO> CreateCandSkill(CandidateSkillsDTO cands)
        {
            _context.candidateSkills.Add(cands);
            _context.SaveChanges();
            return Ok("Data Added!!");
        }
        [HttpPut("{id}/{Sid}")]
        public ActionResult<CandidateSkillsDTO> UpdateCandSkill(Guid id,Guid Sid,CandidateSkillsDTO cands)
        {
            var candsk = _context.candidateSkills.Find(id, Sid);
            if(candsk == null) { return NotFound(); }
            candsk.SkillId = Sid;
            candsk.CandidateId = id;
            candsk.SkillLevel = cands.SkillLevel;
            candsk.IsPrimary = cands.IsPrimary;
            _context.SaveChanges();
            return Ok(candsk);
        }
        [HttpDelete("{id}/{Sid}")]
        public ActionResult DeleteCandSKill(Guid id,Guid Sid)
        {
            var candskill = _context.candidateSkills.FirstOrDefault(cs => cs.CandidateId == id && cs.SkillId == Sid);
            if (candskill == null)
                return NotFound($"Unable to delete. No Candidate SKill found with ID {id}.");
            _context.candidateSkills.Remove(candskill);
            _context.SaveChanges();
            return Ok($"Candidate Skill with ID {id} has been removed.");
        }
    }
}
