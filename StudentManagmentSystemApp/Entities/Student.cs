namespace StudentManagmentSystemApp.Entities
{
    public class Student : Person
    {
        public string StudentCode { get; set; }
        public ICollection<Point> Points { get; set; }
    }
}
