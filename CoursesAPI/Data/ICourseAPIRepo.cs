using System.Collections.Generic;
using CoursesAPI.Models;

namespace CoursesAPI.Data
{
    public interface ICourseAPIRepo{
        bool SaveChanges();

        IEnumerable<Course> GetAllCourses();
        Course GetCourseById(int id);
        void CreateCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);
    }
}