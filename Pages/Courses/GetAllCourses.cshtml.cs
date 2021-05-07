using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZamApp.Models;
using ZamApp.Services.Interface;

namespace ZamApp.Pages.Courses
{
	[Authorize]
    public class GetAllCoursesModel : PageModel
    {
	    public IEnumerable<Course> Courses { get; private set; }

	    private ICourseService _repo;

	    public GetAllCoursesModel(ICourseService repo)
	    {
		    _repo = repo;
	    }
	    public void OnGet()
	    {
			Courses = _repo.GetAllCourses();
		}
    }
}
