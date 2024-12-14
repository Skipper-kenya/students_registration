using Microsoft.EntityFrameworkCore;
using student_registration.Models;

namespace student_registration.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                new Student() {Id=3,Name="Andrew Kimwetich",Registration="BIT/041/21" ,IdNo=55555555,Phone=765383853,School="Science",TechnologyId=1 }
                );

            modelBuilder.Entity<Technology>().HasData(
              new Technology() { Id=1,Name=".NET Developer",StudentId=3 }
              );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Technology> Technologies { get; set; }
    }
}
