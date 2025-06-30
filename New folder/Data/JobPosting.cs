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
    public class JobPosting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid JobPostingId { get; set; }
        public Guid EmployerId { get; set; } 
        public Guid CategoryId { get; set; }
        public Employer Employer { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string WorkMode { get; set; }
        public EmploymentType EmployementType { get; set; }
        public string ExperienceLevel   { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public DateOnly PostedDate { get; set; }
        public DateOnly ClosedDate { get; set; }
        public bool IsActive { get; set; }

        public ICollection<JobApplication> Applications { get; set; }
    }
}
