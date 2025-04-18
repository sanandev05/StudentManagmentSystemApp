namespace StudentManagmentSystemApp.Entities
{
    public class Course : BaseEntity
    {
        public string Code {  get; set; }
        public string  Name {  get; set; }
        public int Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<CourseModule> Units { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
