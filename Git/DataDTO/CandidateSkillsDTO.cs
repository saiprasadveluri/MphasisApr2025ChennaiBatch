using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobSearchAPI.DataDTO.EnumsJob;

namespace JobSearchAPI.DataDTO
{
    public class CandidateSkillsDTO
    {
        public Guid CandidateId { get; set; }
        public Guid SkillId { get; set; }
        [Range((int)SkillLevel.Beginner,(int)SkillLevel.Expert)]
        public SkillLevel SkillLevel { get; set; }
        public bool IsPrimary { get; set; }
    }
}
