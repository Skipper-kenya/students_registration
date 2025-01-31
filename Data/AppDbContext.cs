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

            modelBuilder.Entity<Location>().HasData(
                    new Location() { Id = 1, Name = "Bungoma" },
                    new Location() { Id = 2, Name = "Iten" },
                    new Location() { Id = 3, Name = "Kandara" }

             );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Technology> Technologies { get; set; }

        public DbSet<Location> Locations { get; set; }

    }
}
