using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shipping_Easy.Order
{
    public class Order
    {
        public string Id { get; set; }
        public Recipient Recipient { get; set; }
        public List<LineItem> LineItems { get; set; }
    }
}