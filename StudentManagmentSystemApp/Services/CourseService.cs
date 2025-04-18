using AutoMapper;
using StudentManagmentSystemApp.DTOs.CourseDto;
using StudentManagmentSystemApp.Entities;
using StudentManagmentSystemApp.Repositories.Interfaces;
using StudentManagmentSystemApp.Services.Interfaces;

namespace StudentManagmentSystemApp.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        public CourseService(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<CourseDto> CreateCourseAsync(CourseDto courseDto)
        {
            var createCourse = _mapper.Map<Course>(courseDto);
            await _courseRepository.CreateCourseAsync(createCourse);
            return courseDto;
        }

        public async Task<List<CourseDto>> GetAllAsync()
        {
            var courses = await _courseRepository.GetAllAsync();
            var coursesDto = _mapper.Map<List<CourseDto>>(courses);
            return coursesDto;
        }

        public async Task<CourseDto> GetByIdAsync(int id)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            var courseDto = _mapper.Map<CourseDto>(course);
            return courseDto;
        }

        public  void Update(CourseDto courseDto)
        {
            var getCourse=  _courseRepository.GetByIdAsync(courseDto.Id);
            if (getCourse != null) 
            {
                var course=_mapper.Map<Course>(courseDto);
                _courseRepository.Update(course);
            }
        }
    }
}
