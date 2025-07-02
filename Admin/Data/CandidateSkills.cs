using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobSearchDatabase.EnumsJob;

namespace JobSearchDatabase.Data
{
    public class CandidateSkills
    {
        [Required(ErrorMessage = "Candidate Id is required")]
        public Guid CandidateId { get; set; }
        [ForeignKey(nameof(CandidateId))]
        public Candidate Candidate { get; set; }

        [Required(ErrorMessage = "Skill Id is required")]
        public Guid SkillId { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public bool IsPrimary { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
