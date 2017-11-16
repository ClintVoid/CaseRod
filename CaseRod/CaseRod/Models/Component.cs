﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseRod.Models
{
    public abstract class Component
    {
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
    }
}