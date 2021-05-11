using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

		public Course GetCourse(int id)
		{
			var course = _context.Courses.Include(c => c.Bookings).ThenInclude(b => b.User)
				.AsNoTracking()
				.FirstOrDefault(m => m.CourseId == id);
			//var course = _context.Courses.Include(c => c.Bookings).AsNoTracking().FirstOrDefault(b => b.CourseId == id);
			return course;
			//return _context.Courses.Find(id);
		}

		public Course AddCourse(Course c)
		{
			//GetAllCourses().ToList();
			//List<int> CourseIds = new List<int>();
			//foreach (var item in GetAllCourses())
			//{
			//	CourseIds.Add(item.CourseId);
			//}

			//if (CourseIds.Count != 0)
			//{
			//	int start = CourseIds.Max();
			//	c.CourseId = start + 1;
			//}
			//else
			//{
			//	c.CourseId = 1;
			//}

			_context.Courses.Add(c);
			_context.SaveChanges();
			return c;
		}

		public Course DeleteCourse(int id)
		{
			Course course = _context.Courses.Find(id);
			if (course != null)
			{
				_context.Courses.Remove(course);
				_context.SaveChanges();
			}

			return course;

		}
	}
}
