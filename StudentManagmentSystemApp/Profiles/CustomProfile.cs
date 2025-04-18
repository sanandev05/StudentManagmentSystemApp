using AutoMapper;
using StudentManagmentSystemApp.DTOs.CourseDto;
using StudentManagmentSystemApp.Entities;

namespace StudentManagmentSystemApp.Profiles
{
    public class CustomProfile : Profile
    {
        public CustomProfile()
        {
            CreateMap<Course,CourseDto>();
            CreateMap<CourseDto,Course>();
            //CreateMap<List<CourseDto>,List<Course>>();
            //CreateMap<List<Course>,List<CourseDto>>();
        }
    }
}
