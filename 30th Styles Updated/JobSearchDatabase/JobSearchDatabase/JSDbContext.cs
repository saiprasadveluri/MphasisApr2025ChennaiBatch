using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobSearchDatabase.Data;

namespace JobSearchDatabase
{
    public class JSDbContext : DbContext
    {
        // Constructor MUST be inside the class
        public JSDbContext(DbContextOptions<JSDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<CandidateSkills> candidateSkills { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=JobSearchDB;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidateSkills>().HasKey(cs => new { cs.CandidateId, cs.SkillId });

            modelBuilder.Entity<JobApplication>()
                .HasOne(ja => ja.JobPosting)
                .WithMany(jp => jp.Applications)
                .HasForeignKey(ja => ja.JobPostingId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobApplication>()
                .HasOne(ja => ja.Candidate)
                .WithMany(c => c.Applications)
                .HasForeignKey(ja => ja.CandidateId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
