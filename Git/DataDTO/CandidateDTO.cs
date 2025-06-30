using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchAPI.DataDTO
{
    public class CandidateDTO
    {
        [Key]
        public Guid CandidateId { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        [DataType(DataType.Upload)]
        public string? ResumeFilePath { get; set; }
        public string? ProfileSummary { get; set; }

    }
}
