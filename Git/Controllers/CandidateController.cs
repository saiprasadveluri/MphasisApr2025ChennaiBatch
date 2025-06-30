using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Net;
using System.Reflection;

namespace JobSearchAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatesController : ControllerBase
    {
        private readonly UnitOfWork _uow;

        public CandidatesController(UnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CandidateDTO>> GetRows()
        {
            var employers = _uow.CandRepo.GetAll();
            return Ok(employers);
        }

        [HttpPost]
        public ActionResult<CandidateDTO> CreateRows(CandidateDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _uow.CandRepo.Insert(dto);
            _uow.Save();

            return CreatedAtAction(nameof(GetRows), new { id = dto.CandidateId }, dto);
        }
        [HttpGet("{id}")]
        public ActionResult<CandidateDTO> GetFromId(Guid id)
        {
            var employer = _uow.CandRepo.GetById(id);


            if (employer == null)
            {
                return NotFound($"Employer with ID {id} not found.");
            }
            return Ok(employer);
        }

        [HttpPut("{id}")]
        public ActionResult<CandidateDTO> UpdateRow(Guid id, CandidateDTO updatedemployer)
        {
            var employerup = _uow.CandRepo.UpdateById(id, updatedemployer);
            _uow.Save();
            return Ok(employerup);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRow(Guid id)
        {
            var employer = _uow.CandRepo.DeleteById(id);
            _uow.Save();
            return Ok(employer);
        }
    }

}
