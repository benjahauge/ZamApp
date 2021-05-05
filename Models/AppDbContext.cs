using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ZamApp.Models
{
	public class AppDbContext : IdentityDbContext
	{
		public AppDbContext()
		{
			
		}

		public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
		{
			
		}
		public virtual DbSet<Booking> Bookings { get; set; }
		public virtual DbSet<Course> Courses { get; set; }
		public virtual DbSet<User> Users { get; set; }
	}
}
