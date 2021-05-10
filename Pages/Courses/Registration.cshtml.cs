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
    public class RegistrationModel : PageModel
    {
	    private ICourseService context;

	    public RegistrationModel(ICourseService service)
	    {
		    context = service;
	    }

        public Course Course { get; set; }

        public IActionResult OnGet(int cid)
        {
	        Course = context.GetCourse(cid);
	        if (Course == null)
	        {
		        return NotFound();
	        }

	        return Page();
        }
    }
}
