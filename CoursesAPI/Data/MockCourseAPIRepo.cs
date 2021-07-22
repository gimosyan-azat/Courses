using System.Collections.Generic;
using CoursesAPI.Models;

namespace CoursesAPI.Data
{
    public class MockCourseAPIRepo : ICourseAPIRepo
    {
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
            var courses = new List<Course>
            {
                new Course{
                    Id=0, 
                    Name="Путь к онлайн-продажам",
                    Description="Освойте принципы интернет-продаж и запустите свою воронку, лендинг или интернет-магазин.",
                    ImageURL="https://один-путь.рф/pictures/landing/2/2/223/27d8812bf6344eecbbda9480e7ae9e94.jpg",
                    Price=2000,
                    Duration="1 час 45 минут",
                    LessonsCount=25,
                    PurchaseLink="https://xn----gtbmuckvh6f.xn--p1ai/checkout/lp?lpId=804&products=12484&clear=true",
                    Website="https://xn----gtbmuckvh6f.xn--p1ai/"
                },
                new Course{
                    Id=1, 
                    Name="Выбор воронки для вашего бизнеса",
                    Description="Выбор воронки для вашего бизнеса",
                    ImageURL="https://new.advantshop.net/Areas/Off/Content/courses/images/course-funnels.jpg",
                    Price=990,
                    Duration="2 часа 12 минут",
                    LessonsCount=14,
                    PurchaseLink="https://xn----gtbmuckvh6f.xn--p1ai/checkout/lp?lpId=804&products=12484&clear=true",
                    Website="https://crm.advant.shop/lp/kurs-pro-avtovoronki"
                }
            };

            return courses;
        }

        public Course GetCourseById(int id)
        {
            return new Course{
                    Id=0, 
                    Name="Путь к онлайн-продажам",
                    Description="Освойте принципы интернет-продаж и запустите свою воронку, лендинг или интернет-магазин.",
                    ImageURL="https://один-путь.рф/pictures/landing/2/2/223/27d8812bf6344eecbbda9480e7ae9e94.jpg",
                    Price=2000,
                    Duration="1 час 45 минут",
                    LessonsCount=25,
                    PurchaseLink="https://xn----gtbmuckvh6f.xn--p1ai/checkout/lp?lpId=804&products=12484&clear=true",
                    Website="https://xn----gtbmuckvh6f.xn--p1ai/"
                };
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