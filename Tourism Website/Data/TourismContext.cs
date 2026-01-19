using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Tourism_Website.Data
{
    public class TourismContext : DbContext
    {
        public TourismContext() : base("TourismDB") { }

        public DbSet<User> Users { get; set; }
        public DbSet<TourPackage> TourPackages { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}