using System.Collections.Generic;
using CoursesAPI.Data;
using CoursesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CoursesAPI.Dtos;
using Microsoft.AspNetCore.JsonPatch;

namespace CoursesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseAPIRepo _repository;
        private readonly IMapper _mapper;

        public CoursesController(ICourseAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CoursesReadDto>> GetAllCourses()
        {
            var courses = _repository.GetAllCourses();
            return Ok(_mapper.Map<IEnumerable<CoursesReadDto>>(courses));
        }

        [HttpGet("{id}", Name="GetCourseById")]
        public ActionResult<CoursesReadDto> GetCourseById(int id)
        {
            var course = _repository.GetCourseById(id);
            if (course == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CoursesReadDto>(course));
        }

        [HttpPost]
        public ActionResult<CoursesReadDto> CreateCourse(CoursesCreateDto coursesCreateDto)
        {
            var courseModel = _mapper.Map<Course>(coursesCreateDto);
            _repository.CreateCourse(courseModel);
            _repository.SaveChanges();

            var coursesReadDto = _mapper.Map<CoursesReadDto>(courseModel);

            return CreatedAtRoute(nameof(GetCourseById), new {id = coursesReadDto.Id}, coursesReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult<CoursesUpdateDto> UpdateCourse(int id, CoursesUpdateDto coursesUpdateDto)
        {
            var course = _repository.GetCourseById(id);
            
            if (course == null)
            {
                return NotFound();
            }

            _mapper.Map(coursesUpdateDto, course);
            _repository.UpdateCourse(course);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialCourseUpdate(int id, JsonPatchDocument<CoursesUpdateDto> pathcDoc)
        {
            var course = _repository.GetCourseById(id);
            if (course == null)
            {
                return NotFound();
            }

            var courseToPatch = _mapper.Map<CoursesUpdateDto>(course);
            pathcDoc.ApplyTo(courseToPatch, ModelState);

            if (!TryValidateModel(courseToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(courseToPatch, course);

            _repository.UpdateCourse(course);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult CourseDelete(int id)
        {
            var course = _repository.GetCourseById(id);
            if (course == null)
            {
                return NotFound();
            }

            _repository.DeleteCourse(course);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}