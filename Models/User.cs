using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZamApp.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Email { get; set; }

		public string Address { get; set; }

		
	}
}
