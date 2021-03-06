// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ZamApp.Models
{
    [Index(nameof(CourseId), Name = "IX_Bookings_CourseId")]
    public partial class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int CourseId { get; set; }
        [Required]
        [StringLength(450)]
        public string UserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("Bookings")]
        public virtual Course Course { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(AspNetUser.Bookings))]
        public virtual AspNetUser User { get; set; }
    }
}