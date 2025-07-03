using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccessLayer
{
    public class JsDbContext : DbContext
        {

            public virtual DbSet<Company> Companys { get; set; }
            public virtual DbSet<JobCategory> JobCategorys { get; set; }
            public virtual DbSet<JobNature> JobNatures { get; set; }
            public virtual DbSet<JobStatus> JobStatuss { get; set; }
            public virtual DbSet<User> Users { get; set; }
            public virtual DbSet<UserType> UserTypes { get; set; }
            public virtual DbSet<JobRequirementDetail> JobRequirementDetails { get; set; }
            public virtual DbSet<JobRequirements> JobRequirementss { get; set; }
            public virtual DbSet<PostJob> PostJobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog = JobSearchDBWeb;Integrated Security=True;Trust Server Certificate=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostJob>()
    .HasOne(p => p.User)
    .WithMany(u => u.PostJob)
    .HasForeignKey(p => p.UserID)
    .OnDelete(DeleteBehavior.NoAction);

        }
        //        ALTER TABLE PostJobs
        //ADD CONSTRAINT FK_PostJobs_Users_UserID
        //FOREIGN KEY(UserID) REFERENCES Users(UserID)
        //ON DELETE NO ACTION;
    }
}

