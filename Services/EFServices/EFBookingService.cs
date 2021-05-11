using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZamApp.Models;
using ZamApp.Services.Interface;

namespace ZamApp.Services.EFServices
{
	public class EFBookingService
	{
		private readonly AppDbContext _context;

		public EFBookingService(AppDbContext context)
		{
			_context = context;
		}

		public Booking AddBooking(Booking booking)
		{ 
			_context.Bookings.Add(booking); 
			_context.SaveChanges();
			return booking;
		}

		public IEnumerable<Booking> GetAllBookings()
		{
			return _context.Bookings;
		}
	}
}
