using Microsoft.EntityFrameworkCore;

namespace OnlineQuizApplicationAPI.Models
{
    public class QuizDbContext: DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<AdminInfo> AdminInfos { get; set; }
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Options> Options { get; set; } 
        public DbSet<Category> Category { get; set; }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<QuizAttempt> QuizAttempts { get; set; }

        public QuizDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasIndex(a => a.Email).IsUnique(true);
            modelBuilder.Entity<Questions>().HasIndex(a => a.QuestionText).IsUnique(true);
            modelBuilder.Entity<Account>().ToTable(tb => tb.HasCheckConstraint("CK_Account_Role",
            "[Role] IN ('User', 'Admin')"));

            modelBuilder.Entity<Quiz>().HasMany<Questions>()
                        .WithMany()
                        .UsingEntity(j => j.ToTable("QuizQuestions"));

            modelBuilder.Entity<Options>()
                        .ToTable(tb => tb.HasCheckConstraint(
                            "CK_Options_Answer_ValidValues",
                            "[Answer] IN (0, 1)"
                        ));
            modelBuilder.Entity<Options>().ToTable(tb =>
            {
                // Add a check constraint to ensure Answer is either 0 or 1
                tb.HasCheckConstraint("CK_Options_Answer", "[Answer] IN (0, 1)");
            });
            modelBuilder.Entity<Quiz>().ToTable(entity =>
            {
                entity.HasCheckConstraint(
                    "CK_Quiz_CategoryName",
                    "[CategoryName] IN ('Frontend', 'Backend', 'Database')"
                );
            });
            modelBuilder.Entity<QuizAttempt>().ToTable(entity =>
            {
                //Add check constraint for allowed status values
                entity.HasCheckConstraint(
                "CK_QuizAttempt_Status",
                "[Status] IN ('notstarted', 'pending', 'completed')"
            );
            });

        }
    }
}
