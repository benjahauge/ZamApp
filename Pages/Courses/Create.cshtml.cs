using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZamApp.Models;
using ZamApp.Services.Interface;

namespace ZamApp.Pages.Courses
{
    public class CreateModel : PageModel
    {
	    private readonly ICourseService _repo;

	    [BindProperty] public Course Course { get; set; } = new Course();

        public CreateModel(ICourseService repo)
        {
	        _repo = repo;
        }

        public IActionResult OnGet()
        {
	        return Page();
        }

        public IActionResult OnPost()
        {
	        
	        if (!ModelState.IsValid)
	        {
		        return Page();
	        }

	        _repo.AddCourse(Course);
	        return RedirectToPage("GetAllCourses");
        }
    }
}
