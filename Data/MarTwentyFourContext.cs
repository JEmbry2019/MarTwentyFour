using MarTwentyFour.Models;
using Microsoft.EntityFrameworkCore;

namespace MarTwentyFour.Data
{
    //Creates a new database context named StudentInformationContext(MarTweentyFourContext)
    public class MarTwentyFourContext : DbContext
    {
        public MarTwentyFourContext(DbContextOptions<MarTwentyFourContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Camper> Campers { get; set; }
    }
}