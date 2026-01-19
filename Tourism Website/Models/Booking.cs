using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tourism_Website.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int TourPackageId { get; set; }
        public virtual TourPackage TourPackage { get; set; }

        public int TouristId { get; set; }
        public virtual User Tourist { get; set; }

        public System.DateTime BookingDate { get; set; }
        public BookingStatus Status { get; set; }

        public virtual Review Review { get; set; }
    }
    public enum BookingStatus { Pending, Confirmed, Completed }
}