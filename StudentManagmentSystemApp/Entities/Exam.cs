namespace StudentManagmentSystemApp.Entities
{
    public class Exam : BaseEntity
    {
        public string Title { get; set; }   
        public string Description { get; set; }
        public DateTime ExamDate { get; set; }
        public int CourseID {  get; set; }
        public Course Course { get; set; }
    }
}
