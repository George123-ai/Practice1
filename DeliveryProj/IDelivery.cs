﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProj
{
    internal interface IDelivery
    {
        public int ShippingTime { get; set; } 

        public long TrackingId { get; set; }

        public decimal ShippingCoust { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public decimal Sale { get; set; }


    }
}
