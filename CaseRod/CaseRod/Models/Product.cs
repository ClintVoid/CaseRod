using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseRod.Models
{
    public class Product
    {
        public Blade ChosenBlade { get; set; }
        public Handle ChosenHandle { get; set; }
        public ReelSeat ChosenReelSeat { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
}