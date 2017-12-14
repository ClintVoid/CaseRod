﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CaseRod.Models;

namespace CaseRod.ViewModels
{
    public class AccessoriesViewModel
    {
        public List<Accessory> Cases { get; set; }
        public List<Accessory> Holders { get; set; }
        public List<Accessory> RodTubes { get; set; }
        public Text InfoAccessories { get; set; }
        public Cart Cart { get; set; }
    }
}