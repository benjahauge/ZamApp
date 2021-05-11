﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ZamApp.Models
{
    [Index(nameof(UserId), Name = "IX_Courses_UserId")]
    public partial class Course
    {
        public Course()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public int CourseId { get; set; }
        [Column(TypeName = "date")]
        [Required]
        public DateTime StartDateTime { get; set; }
        [Column(TypeName = "date")]
        [Required]
        public DateTime EndDateTime { get; set; }
        [Required]
        [StringLength(50)]
        public string StartPoint { get; set; }
        [Required]
        [StringLength(50)]
        public string EndPoint { get; set; }
        [Required]
        [StringLength(15)]
        public string ZealandLocation { get; set; }
        [Required]
        [StringLength(50)]
        public string PickUpPoint1 { get; set; }
        [StringLength(50)]
        public string PickUpPoint2 { get; set; }
        [StringLength(50)]
        public string PickUpPoint3 { get; set; }
        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(AspNetUser.Courses))]
        public virtual AspNetUser User { get; set; }
        [InverseProperty(nameof(Booking.Course))]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}