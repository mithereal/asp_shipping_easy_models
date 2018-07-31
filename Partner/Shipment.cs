﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shipping_Easy.Partner
{
    [Serializable]
    public class Shipment
    {
        public string order_number { get; set; }
        public string refund_url { get; set; }
        public string tracking_url { get; set; }
        public string tracking_number { get; set; }
        public string ship_date { get; set; }
        public string carrier { get; set; }
        public string status { get; set; }
        public string carrier_service { get; set; }
        
        public Shipper shipper { get; set; }
    }
}
