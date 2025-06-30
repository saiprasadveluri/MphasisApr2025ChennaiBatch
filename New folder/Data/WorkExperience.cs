using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchDatabase.Data
{
    public class WorkExperience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkExperienceId {  get; set; }
        public Guid CandidateId { get; set; }
        public Candidate  Candidate { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        

    }
}
