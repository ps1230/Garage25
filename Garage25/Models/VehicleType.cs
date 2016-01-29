using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage25.Model
{
    public class VehicleType
    {
        public int VehicleTypeId { get; set; }
        public string Type { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}