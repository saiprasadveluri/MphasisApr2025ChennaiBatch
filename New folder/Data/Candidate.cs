using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchDatabase.Data
{
    public class Candidate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CandidateId { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ResumeFilePath { get; set; }
        public string ProfileSummary { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
        public virtual ICollection<JobApplication> Applications { get; set; }

    }
}
