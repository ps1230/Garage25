using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage25.Model
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string TelephoneNo { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}