namespace StudentManagmentSystemApp.Entities
{
    public class CourseModule
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }              
        public ICollection<Unit> Units { get; set; }
    }
}
