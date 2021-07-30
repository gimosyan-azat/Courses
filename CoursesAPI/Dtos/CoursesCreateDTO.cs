using System.ComponentModel.DataAnnotations;

namespace CoursesAPI.Dtos
{
    public class CoursesCreateDto 
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        public string Website { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string PurchaseLink { get; set; }

        [Required]
        public int LessonsCount { get; set; }

        [Required]
        public string Duration { get; set; }
    }
}