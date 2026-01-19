using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tourism_Website.Models
{
    public class TourPackage
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Range(1, 365)]
        public int DurationDays { get; set; }

        [Range(0, 10000)]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public int AgencyId { get; set; }
        public virtual User Agency { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}