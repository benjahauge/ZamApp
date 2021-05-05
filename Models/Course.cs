using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZamApp.Models
{
	public class Course
	{
		[Key]
		public int CourseId { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
		[Required]
		[StringLength(50)]
		public string StartPoint { get; set; }

		[Required]
		[StringLength(50)]
		public string EndPoint { get; set; }

		[Required]
		[StringLength(50)]
		public string ZealandLocation { get; set; }

		[Required]
		[StringLength(50)]
		public string PickUpPoint1 { get; set; }

		[StringLength(50)]
		public string PickUpPoint2 { get; set; }

		[StringLength(50)]
		public string PickUpPoint3 { get; set; }

		public virtual ICollection<Booking> Bookings { get; set; }
	}
}
