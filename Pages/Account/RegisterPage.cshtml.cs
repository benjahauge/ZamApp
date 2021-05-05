using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZamApp.ViewModel;

namespace ZamApp.Pages.Account
{
    public class RegisterPageModel : PageModel
    {
		private readonly UserManager<IdentityUser> userManager;
		private readonly SignInManager<IdentityUser> signInManager;

		[BindProperty]
	    public RegisterViewModel Registration { get; set; }

	    public RegisterPageModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
	    {
			this.userManager = userManager;
			this.signInManager = signInManager;
		}

	    public void OnGet()
        {
        }

	    public async Task<IActionResult> OnPost()
	    {
		    if (!ModelState.IsValid)
		    {
			    return Page();
		    }

		    var user = new IdentityUser() {Email = Registration.Email, UserName = Registration.Email};
		    var result = await userManager.CreateAsync(user, Registration.Password);
		    if (result.Succeeded)
		    {
			    await signInManager.SignInAsync(user, isPersistent: false);
			    return RedirectToPage("/Courses/GetAllCourses");
		    }
		    else
			    foreach (var er in result.Errors)
			    {
					ModelState.AddModelError(string.Empty, er.Description);
				}

		    return Page();



	    }
    }
}
