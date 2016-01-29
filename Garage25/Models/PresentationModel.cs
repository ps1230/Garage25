using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage25.Model
{
    public class PresentationModel
    {
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string VehicleType { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime ParkingTime { get; set; }
    }
}