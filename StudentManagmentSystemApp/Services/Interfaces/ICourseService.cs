using StudentManagmentSystemApp.DTOs.CourseDto;
using StudentManagmentSystemApp.Entities;

namespace StudentManagmentSystemApp.Services.Interfaces
{
    public interface ICourseService
    {
        Task<List<CourseDto>> GetAllAsync();
        Task<CourseDto> GetByIdAsync(int id);
        void Update(CourseDto courseDto);
        Task<CourseDto> CreateCourseAsync(CourseDto courseDto);
    }
}
