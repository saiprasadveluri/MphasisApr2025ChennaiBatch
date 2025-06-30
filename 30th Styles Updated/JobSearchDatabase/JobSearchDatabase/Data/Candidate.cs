using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchDatabase.Data
{
    public class Candidate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CandidateId { get; set; }

        [Required(ErrorMessage = "User is required")]
        public Guid UserId { get; set; }

        public User? User { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(100)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(100)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [StringLength(10)]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "Address is required")]
        [StringLength(250)]
        public string Address { get; set; } = null!;

        [StringLength(250)]
        public string? ResumeFilePath { get; set; }

        [StringLength(1000)]
        public string? ProfileSummary { get; set; }

        public virtual ICollection<Education> Educations { get; set; } = new List<Education>();

        public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();

        public virtual ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();
    }
}
