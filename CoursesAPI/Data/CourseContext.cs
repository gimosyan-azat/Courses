using Microsoft.EntityFrameworkCore;
using CoursesAPI.Models;

namespace CoursesAPI.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {

        }

        public DbSet<Course> CourseItems {get; set;}
    }
}