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
    public class JobPostingDTO
    {
        [Key]
        public Guid JobPostingId { get; set; }
        [Required]
        public Guid EmployerId { get; set; } 
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }

        public string? WorkMode { get; set; }
        [Range((int)EmploymentType.FullTime,(int)EmploymentType.Other)]
        public EmploymentType EmployementType { get; set; }
        public string? ExperienceLevel   { get; set; }
        public string? Location { get; set; }
        public string? SalaryRange { get; set; }
        public DateOnly PostedDate { get; set; }
        public DateOnly ClosedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
