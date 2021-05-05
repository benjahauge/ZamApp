using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZamApp.Models;
using ZamApp.Services.Interface;

namespace ZamApp.Services.EFServices
{
	public class EFCourseService : ICourseService
	{
		private readonly AppDbContext _context;

		public EFCourseService(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Course> GetAllCourses()
		{
			return _context.Courses;
		}
	}
}
