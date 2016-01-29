using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Garage25.Model;

namespace Garage25.Models
{
    public class GarageContext : DbContext
    {
          public GarageContext() : base ("GarageContextDb")
        {

        }
        
        public DbSet<Member> Members { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
    }
}