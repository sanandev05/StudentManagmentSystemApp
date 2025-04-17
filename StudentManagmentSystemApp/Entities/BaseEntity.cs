namespace StudentManagmentSystemApp.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Deleted {  get; set; }
    }
}
