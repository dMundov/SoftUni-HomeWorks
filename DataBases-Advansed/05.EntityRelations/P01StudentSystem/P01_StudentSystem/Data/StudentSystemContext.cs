namespace P01_StudentSystem.Data
{
    using Microsoft.EntityFrameworkCore;
    using P01_StudentSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {

        }

        public StudentSystemContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> HomeworkSubmissions { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder
            modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(st => st.StudentId);

                entity
                    .Property(st => st.Name)
                    .HasMaxLength(100)
                    .IsUnicode(true)
                    .IsRequired(true);

                entity
                    .Property(st => st.PhoneNumber)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .IsUnicode(false);

            });
            
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(c => c.CourseId);

                entity
                    .Property(c => c.Name)
                    .HasMaxLength(80)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(c => c.Description)
                    .HasMaxLength(300)
                    .IsRequired(false)
                    .IsUnicode(true);

                entity
                    .Property(c => c.StartDate)
                    .IsRequired(true);

                entity
                    .Property(c => c.EndDate)
                    .IsRequired(true);

                entity
                    .Property(c => c.Price)
                    .IsRequired(true)
                    .HasColumnType("decimal(18,2)");
                    
                
                   

            });

            modelBuilder.Entity<Homework>(entity =>
            {
                
                entity.HasKey(h => h.HomeworkId);

                entity
                    .Property(h => h.Content)
                    .IsUnicode(false)
                    .IsRequired();

                entity
                    .Property(h => h.SubmissionTime)
                    .HasDefaultValue(DateTime.UtcNow);

                entity
                    .HasOne(h => h.Student)
                    .WithMany(s => s.HomeworkSubmissions)
                    .HasForeignKey(h => h.StudentId);

                entity
                     .HasOne(h => h.Course)
                     .WithMany(c => c.HomeworkSubmissions)
                     .HasForeignKey(h => h.CourseId);

            });

            modelBuilder.Entity<Resource>(entity =>
            {
               
                entity.HasKey(r => r.ResourceId);

                entity
                    .Property(r => r.Name)
                    .HasMaxLength(50)
                    .IsUnicode()
                    .IsRequired();

                entity
                    .HasIndex(r => r.Url)
                    .IsUnique(true);

                entity
                    .Property(r => r.Url)
                    .IsUnicode(false)
                    .IsRequired();

                entity
                    .HasOne(r => r.Course)
                    .WithMany(c => c.Resources)
                    .HasForeignKey(r => r.CourseId);
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity
                    .HasKey(sc => new { sc.StudentId, sc.CourseId });

                entity
                    .HasOne(sc => sc.Student)
                    .WithMany(s => s.CourseEnrollments)
                    .HasForeignKey(sc => sc.StudentId);

                entity
                    .HasOne(sc => sc.Course)
                    .WithMany(c => c.StudentsEnrolled)
                    .HasForeignKey(sc => sc.CourseId);
            });

        }

       
    }
}
