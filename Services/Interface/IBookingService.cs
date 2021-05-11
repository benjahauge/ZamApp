using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZamApp.Models;

namespace ZamApp.Services.Interface
{
	public interface IBookingService
	{
		IEnumerable<Booking> GetAllBookings();
		Booking AddBooking(Booking booking);
	}
}
