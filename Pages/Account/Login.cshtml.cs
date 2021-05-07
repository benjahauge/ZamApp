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
    public class LoginModel : PageModel
    {
	    [BindProperty]
	    public LoginViewModel loginModel { get; set; }
	    private readonly SignInManager<IdentityUser> signInManager;

	    public LoginModel(SignInManager<IdentityUser> signInManager)
	    {
		    this.signInManager = signInManager;
	    }

		public string URL { get; set; }

        public void OnGet(string ReturnUrl)
        {
	        URL = ReturnUrl;
        }

        public async Task<IActionResult> OnPost()
        {
	        if (!ModelState.IsValid)
	        {
		        return Page();
	        }
	        else
	        {
		        var result = await signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
		        if (result.Succeeded)
		        {
			        return RedirectToPage("Courses/GetAllCourses");
		        }
		        else
		        {
			        ModelState.AddModelError(string.Empty, "Invalid data");
			        return Page();
		        }
	        }
        }
    }
}
