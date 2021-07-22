using System.Collections.Generic;
using CoursesAPI.Data;
using CoursesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoursesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseAPIRepo _repository;

        public CoursesController(ICourseAPIRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetAllCourses()
        {
            var courses = _repository.GetAllCourses();
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetAllCourseById(int id)
        {
            var course = _repository.GetCourseById(id);
            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }
    }
}