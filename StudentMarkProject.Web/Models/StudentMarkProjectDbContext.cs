using Microsoft.EntityFrameworkCore;

namespace StudentMarkProject.Web.Models
{
    public class StudentMarkProjectDbContext : DbContext 
    {
        public DbSet<Student> Students {  get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentEnrollment> StudentEnrollments { get; set; }
        public DbSet<TeacherEnrollment> TeacherEnrollments { get; set; }
        public DbSet<StudentMark> StudentMarks { get; set; }

        public StudentMarkProjectDbContext(DbContextOptions<StudentMarkProjectDbContext> options) : base(options) 
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(Localdb)\\MSSQLLocaldb;Database=StudetnMark;Trusted_Connection=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
