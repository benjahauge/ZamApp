using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZamApp.Pages.Account
{
    public class LogOutModel : PageModel
    {
	    public SignInManager<IdentityUser> signInManager { get; }
	    public LogOutModel(SignInManager<IdentityUser> signIn)
	    {
		    signInManager = signIn;
	    }
	    public void OnGet()
	    {
	    }

	    public async Task<IActionResult> OnPost()
	    {
		    await signInManager.SignOutAsync();
		    return RedirectToPage("/Index");
	    }
	}
}
