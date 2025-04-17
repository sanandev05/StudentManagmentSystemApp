using StudentManagmentSystemApp.Enums;

namespace StudentManagmentSystemApp.Entities
{
    public class Point : BaseEntity
    {
        public PointType PointType { get; set; }
        public double Result { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
