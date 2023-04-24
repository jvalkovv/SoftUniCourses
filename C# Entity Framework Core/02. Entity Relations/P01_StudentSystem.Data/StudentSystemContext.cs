using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {

        }

        //Judge
        public StudentSystemContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; } = null!;

        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<StudentCourse> StudentsCourses { get; set; } = null!;

        public DbSet<Resource> Resources { get; set; } = null!;

        public DbSet<Homework> Homeworks { get; set; } = null!;



        //Establish a connection to the SQL Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //True -> Connection string is already set
            //False -> Connection string isn't set
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=StudentSystem;Integrated Security=true;Encrypt=false;");
            }

        }

        //Define rules for creating db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            //Composite PK of mapping entity
            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.CourseId });

            });


        }

    }
}