namespace StudentManagmentSystemApp.Entities
{
    public abstract class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime BirthTime { get; set; }
    }
}
