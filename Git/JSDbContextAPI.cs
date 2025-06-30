using JobSearchAPI.DataDTO;
using Microsoft.EntityFrameworkCore;
namespace JobSearchAPI
{
    public class JSDbContextAPI : DbContext
    {
        public JSDbContextAPI(DbContextOptions options) : base(options) { }
        public DbSet<UserDTO> Users { get; set; }
        public DbSet<CandidateDTO> Candidates { get; set; }

        public DbSet<WorkExperienceDTO> WorkExperiences { get; set; }
        public DbSet<SkillDTO> Skills { get; set; }

        public DbSet<CandidateSkillsDTO> candidateSkills { get; set; }
        public DbSet<EducationDTO> Educations { get; set; }
        public DbSet<EmployerDTO> Employers { get; set; }
        public DbSet<JobApplicationDTO> JobApplications { get; set; }
        public DbSet<JobCategoryDTO> JobCategories { get; set; }
        public DbSet<JobPostingDTO> JobPostings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CandidateSkillsDTO>().HasNoKey();
            modelBuilder.Entity<CandidateSkillsDTO>().HasKey(cs => new { cs.CandidateId, cs.SkillId });
        }
    }
}
