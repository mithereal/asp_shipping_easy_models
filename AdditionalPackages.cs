using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shipping_Easy
{
    public class AdditionalPackages
    {
        public string description { get; set; }
        public string tracking_number { get; set; }
        public string weight_in_ounces { get; set; }
        public string length_in_inches { get; set; }
        public string width_in_inches { get; set; }
        public string height_in_inches { get; set; }
    }
}