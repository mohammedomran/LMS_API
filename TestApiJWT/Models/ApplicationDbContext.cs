using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestApiJWT.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonItems> LessonItems { get; set; }

    }
}