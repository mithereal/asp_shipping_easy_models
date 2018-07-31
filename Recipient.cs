﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shipping_Easy
{
    [Serializable]
    public class Recipient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
   
    }
}