using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseRod.Models
{
    public class Accessory: Component
    {
        public enum AccessoryType
        {
            Case, Holder, RodTube
        }

        public AccessoryType Type { get; set; }

    }
}