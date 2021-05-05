using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZamApp.ViewModel;

namespace ZamApp.Pages.Account
{
    public class RegisterPageModel : PageModel
    {
	    [BindProperty]
	    public RegisterViewModel Registration { get; set; }
        
	    public void OnGet()
        {
        }
    }
}
