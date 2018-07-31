using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shipping_Easy.Partner
{
    [Serializable]
    public class Shipper
    {
        public string external_identifier { get; set; }
        public string name { get; set; }
        public string email { get; set; }
       
    }
}
