using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProj
{
    internal interface ITransport
    {
        public string ShipTime { get; set; }

        int MaxWeight { get; set; }

        public int MinWeight { get; set; }

        public string[] CountryRestriction { get; set; }

        int ShippingCost { get; set; }
    }
}
