using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shipping_Easy
{
    public class Orders
    {
        public string id { get; set; }
        public string external_order_identifier { get; set; }
        public string ordered_at { get; set; }
        public string order_status { get; set; }
        public string parent_order_id { get; set; }
        public string source_order_ids { get; set; }
        public string total_including_tax { get; set; }
        public string total_excluding_tax { get; set; }
        public string discount_amount { get; set; }
        public string coupon_discount { get; set; }
        public string subtotal_including_tax { get; set; }
        public string subtotal_excluding_tax { get; set; }
        public string subtotal_tax { get; set; }
        public string total_tax { get; set; }
        public string base_shipping_cost { get; set; }
        public string shipping_cost_including_tax { get; set; }
        public string shipping_cost_excluding_tax { get; set; }
        public string shipping_cost_tax { get; set; }
        public string base_handling_cost { get; set; }
        public string handling_cost_excluding_tax { get; set; }
        public string handling_cost_including_tax { get; set; }
        public string handling_cost_tax { get; set; }
        public string base_wrapping_cost { get; set; }
        public string wrapping_cost_excluding_tax { get; set; }
        public string wrapping_cost_including_tax { get; set; }
        public string wrapping_cost_tax { get; set; }
        public string billing_company { get; set; }
        public string billing_first_name { get; set; }
        public string billing_last_name { get; set; }
        public string billing_address { get; set; }
        public string billing_address2 { get; set; }
        public string billing_city { get; set; }
        public string billing_state { get; set; }
        public string billing_country { get; set; }
        public string billing_postal_code { get; set; }
        public string billing_phone_number { get; set; }
        public string billing_email { get; set; }
        public string store_api_key { get; set; }
        public string updated_at { get; set; }
        public string notes { get; set; }

        public EasyShipData recipients { get; set; }
        public EasyShipLabel shipments { get; set; }
    }
}