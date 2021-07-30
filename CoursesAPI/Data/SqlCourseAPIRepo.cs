using System.Collections.Generic;
using CoursesAPI.Models;
using System.Linq;
using System;

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
            if (course == null)
            {
                throw new ArgumentException(nameof(course));
            }

            _context.CourseItems.Add(course);
        }

        public void DeleteCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(nameof(course));
            }

            _context.CourseItems.Remove(course);
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
            return(_context.SaveChanges() >= 0);
        }

        public void UpdateCourse(Course course)
        {
            
        }
    }
}