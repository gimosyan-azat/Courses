namespace CoursesAPI.Dtos
{
    public class CoursesReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string Website { get; set; }
        public decimal Price { get; set; }
        public string PurchaseLink { get; set; }
        public int LessonsCount { get; set; }
        public string Duration { get; set; }
    }
}