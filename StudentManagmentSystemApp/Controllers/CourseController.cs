using Microsoft.AspNetCore.Mvc;
using StudentManagmentSystemApp.DTOs.CourseDto;
using StudentManagmentSystemApp.Services.Interfaces;

namespace StudentManagmentSystemApp.Controllers
{
    public class CourseController : Controller
    {
        ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items = await _courseService.GetAllAsync();
            return View(items);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CourseDto dto)
        {
            return RedirectToAction("Index");
           
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var item=await _courseService.GetByIdAsync(id);
            return RedirectToAction("Index");

        }
    }
}
