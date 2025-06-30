using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobSearchAPI.DataDTO.EnumsJob;

namespace JobSearchAPI.DataDTO
{
    public class JobApplicationDTO
    {
        [Key]
        public Guid ApplicationId { get; set; }
        [Required]
        public Guid JobPostingId { get; set; }
        public Guid CandidateId { get; set; }
        public DateOnly AppliedDate { get; set; }
        [Range((int)JobStatus.Open,(int)JobStatus.Filled)]
        public JobStatus Status { get; set; }


    }
}
