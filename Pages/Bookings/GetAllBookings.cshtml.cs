using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZamApp.Models;
using ZamApp.Services.Interface;

namespace ZamApp.Pages.Bookings
{
    public class GetAllBookingsModel : PageModel
    {
	    public IEnumerable<Booking> Bookings { get; private set; }

	    private IBookingService repo;

	    public GetAllBookingsModel(IBookingService repo)
	    {
		    this.repo = repo;
	    }

	    public void OnGet()
	    {
		    Bookings = repo.GetAllBookings();
	    }
    }
}
