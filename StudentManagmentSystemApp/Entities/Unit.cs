namespace StudentManagmentSystemApp.Entities
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseModuleId { get; set; }
        public CourseModule CourseModule { get; set; }
    }
}
