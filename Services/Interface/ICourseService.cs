using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZamApp.Models;

namespace ZamApp.Services.Interface
{
	public interface ICourseService
	{
		IEnumerable<Course> GetAllCourses();
		Course GetCourse(int id);
		Course AddCourse(Course c);
	}
}
