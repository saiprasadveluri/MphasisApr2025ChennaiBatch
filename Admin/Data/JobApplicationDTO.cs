using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobSearchDatabase.EnumsJob;

namespace JobSearchDatabase.Data
{
    public class JobApplicationDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ApplicationId { get; set; }
        public Guid JobPostingId { get; set; }
        [ForeignKey(nameof(JobPostingId))]
        public JobPosting JobPosting { get; set; }
        public Guid CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public DateOnly AppliedDate { get; set; }
        public JobStatus Status { get; set; }


    }
}
