namespace StudentManagmentSystemApp.Entities
{
    public class Course : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        ICollection<CourseModule> CourseModules { get; set; }
        ICollection<Exam> Exams { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
