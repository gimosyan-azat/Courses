using System.Collections.Generic;
using CoursesAPI.Models;
using System.Linq;

namespace CoursesAPI.Data
{
    public class SqlCourseAPIRepo : ICourseAPIRepo
    {
        private readonly CourseContext _context;

        public SqlCourseAPIRepo(CourseContext context)
        {
            _context = context;
        }

        public void CreateCourse(Course course)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCourse(Course course)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.CourseItems.ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.CourseItems.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCourse(Course course)
        {
            throw new System.NotImplementedException();
        }
    }
}