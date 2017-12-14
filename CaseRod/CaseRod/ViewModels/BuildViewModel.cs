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
        public Text InfoHeader { get; set; }
        public Text InfoBladesHeader { get; set; }
        public Text InfoHandlesHeader { get; set; }
        public Text InfoReelsHeader { get; set; }
        public Text InfoBody { get; set; }
        public Text InfoBladesBody { get; set; }
        public Text InfoHandlesBody { get; set; }
        public Text InfoReelsBody { get; set; }
        public Cart Cart { get; set; }
    }
}