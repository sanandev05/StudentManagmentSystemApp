using StudentManagmentSystemApp.Entities;

namespace StudentManagmentSystemApp.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllAsync();
        Task<Course> GetByIdAsync(int id);
        void Update(Course course);
        Task<Course> CreateCourseAsync(Course course);
    }
}
