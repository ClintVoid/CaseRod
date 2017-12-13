using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaseRod.Models
{
    public class Text
    {
        [Key]
        public string Name { get; set; }
        public string Content { get; set; }
    }
}