using AutoMapper;
using CoursesAPI.Dtos;
using CoursesAPI.Models;

namespace CoursesAPI.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Course, CoursesReadDto>();
            CreateMap<CoursesCreateDto, Course>();
            CreateMap<CoursesUpdateDto, Course>();
            CreateMap<Course, CoursesUpdateDto>();
        }
    }
}