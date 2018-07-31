﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shipping_Easy
{
    [Serializable]
    public class ShippingLabel
    {
        public string order_number { get; set; }
        public string refund_url { get; set; }
        public string tracking_url { get; set; }
        public string tracking_number { get; set; }
        public string ship_date { get; set; }
        public string carrier { get; set; }
        public string status { get; set; }
        public string carrier_service { get; set; }
        public string label_api_url { get; set; }
        public string external_identifier { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public Dictionary<string, object> partner_user { get; set; }

    }
}
