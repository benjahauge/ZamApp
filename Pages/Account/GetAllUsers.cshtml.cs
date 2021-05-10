using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZamApp.Models;

namespace ZamApp.Pages.Account
{
    public class GetAllUsersModel : PageModel
    {
	    private readonly AppDbContext context;
	    private readonly SignInManager<IdentityUser> signIn;

        public IQueryable<AspNetUser> Users { get; set; }

        public GetAllUsersModel(AppDbContext context, SignInManager<IdentityUser> signIn)
        {
	        this.context = context;
	        this.signIn = signIn;
        }
        public void OnGet()
        {
	        Users = context.Users;
        }
    }
}
