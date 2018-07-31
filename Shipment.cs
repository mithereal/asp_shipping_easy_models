using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shipping_Easy
{
    public class Shipment
    {
        public string id { get; set; }
        public string tracking_number { get; set; }
        public string carrier_key { get; set; }
        public string carrier_service_key { get; set; }
        public string shipment_cost { get; set; }
        public string weight_in_ounces { get; set; }
        public string ship_date { get; set; }
        public string workflow_state { get; set; }
        public string cloned_from_shipment_id { get; set; }
        public string length_in_inches { get; set; }
        public string width_in_inches { get; set; }
        public string height_in_inches { get; set; }
        

        public AdditionalPackages additional_packages { get; set; }
        public Orders orders { get; set; }
       

 

    }
}