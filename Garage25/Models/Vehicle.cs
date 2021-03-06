﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage25.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        [Display(Name = "Registration Number")]
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int WheelCount { get; set; }
        [Display(Name = "Parked Since")]
        public DateTime ParkTime { get; set; }
        [Display(Name="Vehicle Type")]
        public int VehicleTypeId { get; set; }
        [Display(Name="Member")]
        public int MemberId { get; set; }

        public virtual Member Member { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    }
}