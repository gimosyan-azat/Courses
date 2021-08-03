using System;
using Xunit;
using CoursesAPI.Models;

namespace CoursesAPI.Tests
{
    public class CourseTests : IDisposable
    {
        Course testCourse = new Course
            {
                Id = 0,
                Name = "Путь к онлайн-продажам",
                Description = "Освойте принципы интернет-продаж и запустите свою воронку, лендинг или интернет-магазин.",
                ImageURL = "https://один-путь.рф/pictures/landing/2/2/223/27d8812bf6344eecbbda9480e7ae9e94.jpg",
                Price = 2000,
                Duration = "1 час 45 минут",
                LessonsCount = 25,
                PurchaseLink = "https://xn----gtbmuckvh6f.xn--p1ai/checkout/lp?lpId=804&products=12484&clear=true",
                Website = "https://xn----gtbmuckvh6f.xn--p1ai/"
            };

        [Fact]
        public void CanChangeDuration()
        {
            testCourse.Duration = "FUCK YOU BITCH";

            Assert.Equal("FUCK YOU BITCH", testCourse.Duration);
        }

        public void Dispose()
        {
            testCourse = null;
        }
    }
}