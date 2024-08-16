using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext(DbContextOptions<FinalProjectContext> options)
            : base(options)
        { }

        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configure entities
            modelBuilder.ApplyConfiguration(new ConfigureTeachers());
            modelBuilder.ApplyConfiguration(new ConfigureCourses());
        }

    }
}
