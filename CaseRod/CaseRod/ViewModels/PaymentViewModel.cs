using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CaseRod.Models;

namespace CaseRod.ViewModels
{
    public class PaymentViewModel
    {
        public Text PaymentHeader { get; set; }
        public Text PaymentBody { get; set; }
        public Text ShippingHeader { get; set; }
        public Text ShippingBody { get; set; }
    }
}