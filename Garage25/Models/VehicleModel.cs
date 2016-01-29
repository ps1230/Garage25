using Garage25.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage25.Models
{
    public class VehicleModel
    {
        public Vehicle Vehicle { get; set; }
        public ICollection<VehicleType> VehicleTypes { get; set; }
    }
}