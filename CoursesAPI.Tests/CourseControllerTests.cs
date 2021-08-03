using System;
using Xunit;
using CoursesAPI.Controllers;
using CoursesAPI.Models;
using CoursesAPI.Data;
using CoursesAPI.Profiles;
using CoursesAPI.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Moq;
using AutoMapper;

namespace CoursesAPI.Tests
{
    public class CourseControllerTests : IDisposable
    {
        Mock<ICourseAPIRepo> mockRepo;
        CoursesProfile realProfile;
        MapperConfiguration configuration;
        IMapper mapper;

        [Fact]        
        public void GetCourseItems_ReturnZenoItems_WhenDBIsEmpty()
        {
            mockRepo = new Mock<ICourseAPIRepo>();
            mockRepo.Setup(repo => 
                repo.GetAllCourses()).Returns(GetCourses(0));
            
            realProfile = new CoursesProfile();
            configuration = new MapperConfiguration (cfg =>
                cfg.AddProfile(realProfile));
            mapper = new Mapper(configuration);

            var controller = new CoursesController(mockRepo.Object, mapper);

            var result = controller.GetAllCourses();
            Assert.IsType<OkObjectResult>(result.Result);
        }

        public void Dispose()
        {
            mockRepo = null;
            mapper = null;
            configuration = null;
            realProfile = null;
        }

        private List<Course> GetCourses(int num)
        {
            var courses = new List<Course>();
            if (num > 0){
                courses.Add(new Course{
                    Id=0, 
                    Name="Путь к онлайн-продажам",
                    Description="Освойте принципы интернет-продаж и запустите свою воронку, лендинг или интернет-магазин.",
                    ImageURL="https://один-путь.рф/pictures/landing/2/2/223/27d8812bf6344eecbbda9480e7ae9e94.jpg",
                    Price=2000,
                    Duration="1 час 45 минут",
                    LessonsCount=25,
                    PurchaseLink="https://xn----gtbmuckvh6f.xn--p1ai/checkout/lp?lpId=804&products=12484&clear=true",
                    Website="https://xn----gtbmuckvh6f.xn--p1ai/"
                });
            }
            return courses;
        }
    }
}