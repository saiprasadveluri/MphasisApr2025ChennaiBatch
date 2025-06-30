using System.ComponentModel.DataAnnotations;

namespace JobSearchAPI.DataDTO
{
    public class UserCandEmp:UserDTO
    {
        public Candidates? Candidate { get; set; }
            public Employers? Employer { get; set; }
        }

        public class Candidates
        {
        [Key]
        public Guid CandidateId{ get; set; }
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

        public class Employers
    {
        [Key]
        public Guid EmployerId { get; set; }
        public Guid UserId { get; set; }
            public string? CompanyName { get; set; }
            public string? CompanyDescription { get; set; }
            public string? WebsiteUrl { get; set; }
            public string? EmployerName { get; set; }
            public string? Designation { get; set; }
        }
    }

