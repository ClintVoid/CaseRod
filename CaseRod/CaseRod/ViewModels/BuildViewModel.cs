using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CaseRod.Models;

namespace CaseRod.ViewModels
{
    public class BuildViewModel
    {
        public List<Blade> Blades { get; set; }
        public List<Handle> Handles { get; set; }
        public List<ReelSeat> ReelSeats { get; set; }
        public Blade ChosenBlade { get; set; }
        public Handle ChosenHandle { get; set; }
        public ReelSeat ChosenReelSeat { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
    }
}