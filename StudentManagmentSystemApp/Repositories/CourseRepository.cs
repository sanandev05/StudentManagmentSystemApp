using Microsoft.EntityFrameworkCore;
using StudentManagmentSystemApp.Data;
using StudentManagmentSystemApp.Entities;
using StudentManagmentSystemApp.Repositories.Interfaces;

namespace StudentManagmentSystemApp.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _context;
        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Course> CreateCourseAsync(Course course)
        {
            await _context.AddAsync(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<List<Course>> GetAllAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetByIdAsync(int id)
        {
            return await _context.Courses.FirstOrDefaultAsync(x=>x.ID==id);
        }

        public void Update(Course course)
        {
            _context.Courses.Update(course);
        }
    }
}
