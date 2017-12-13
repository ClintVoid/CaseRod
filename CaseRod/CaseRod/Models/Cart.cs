using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseRod.Models
{
    public class Cart
    {
        public Blade Blade { get; set; }
        public Handle Handle { get; set; }
        public ReelSeat ReelSeat { get; set; }
    }
}