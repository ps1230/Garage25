using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage25.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int WheelCount { get; set; }
        public DateTime ParkTime { get; set; }
        public int VehicleTypeId { get; set; }
        public int MemberId { get; set; }

        public virtual Member Member { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    }
}