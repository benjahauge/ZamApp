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
    public class DeleteModel : PageModel
    {
	    private readonly ICourseService repo;


	    public DeleteModel(ICourseService repo)
	    {
			this.repo = repo;
		}

		[BindProperty]
		public Course Course { get; set; }

		public IActionResult OnGet(int id)
		{
			Course = repo.GetCourse(id);
			return Page();
		}

		public IActionResult OnPost(int id)
		{
			repo.DeleteCourse(id);
			return RedirectToPage("GetAllCourses");
		}
	}
}
