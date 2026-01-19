using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tourism_Website.Models
{
    
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public UserRole Role { get; set; }

        public virtual ICollection<TourPackage> TourPackages { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

    }
    public enum UserRole { Tourist, Agency }
}