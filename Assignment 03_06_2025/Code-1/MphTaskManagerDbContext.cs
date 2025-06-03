using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TaskmanagerEFConsole;

public partial class MphTaskManagerDbContext : DbContext
{
    public MphTaskManagerDbContext()
    {
    }

    public MphTaskManagerDbContext(DbContextOptions<MphTaskManagerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectMember> ProjectMembers { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<TaskTypeMaster> TaskTypeMasters { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MphTaskManagerDB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.Property(e => e.CommentId).ValueGeneratedOnAdd();
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.CommentNavigation).WithOne(p => p.Comment)
                .HasForeignKey<Comment>(d => d.CommentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_ProjectMember");

            entity.HasOne(d => d.Comment1).WithOne(p => p.Comment)
                .HasForeignKey<Comment>(d => d.CommentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_Tasks");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasIndex(e => e.Title, "IX_Projects").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<ProjectMember>(entity =>
        {
            entity.HasKey(e => e.MemberId);

            entity.ToTable("ProjectMember");

            entity.HasIndex(e => new { e.ProjId, e.UserId }, "IX_ProjectMember").IsUnique();

            entity.HasOne(d => d.Proj).WithMany(p => p.ProjectMembers)
                .HasForeignKey(d => d.ProjId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectMember_Projects");

            entity.HasOne(d => d.User).WithMany(p => p.ProjectMembers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectMember_UserInfos");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.TaskTitle).HasMaxLength(50);
            entity.Property(e => e.TaskType).HasMaxLength(30);

            entity.HasOne(d => d.AssignedToNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.AssignedTo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tasks_ProjectMember");

            entity.HasOne(d => d.Project).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tasks_Projects");

            entity.HasOne(d => d.TaskStatusNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.TaskStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tasks_TaskTypeMaster");
        });

        modelBuilder.Entity<TaskTypeMaster>(entity =>
        {
            entity.HasKey(e => e.TaskTypeId);

            entity.ToTable("TaskTypeMaster");

            entity.HasIndex(e => e.TaskTypeName, "IX_TaskTypeMaster").IsUnique();

            entity.Property(e => e.TaskTypeId).ValueGeneratedNever();
            entity.Property(e => e.TaskTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.HasIndex(e => e.Email, "IX_UserInfos").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(20);

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.UserInfos)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserInfos_UserRoles");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.Property(e => e.RoleId).ValueGeneratedNever();
            entity.Property(e => e.RoleName).HasMaxLength(20);
        });
            
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
