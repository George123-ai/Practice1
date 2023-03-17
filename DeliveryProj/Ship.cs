using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProj
{
    internal class Ship : ITransport
    {
        public string ShipTime { get; set; } = "1 month";
        public int MinWeight { get; set; } = 1000;
        public int MaxWeight { get; set; } = 4000;
        public string[] CountryRestriction { get; set; } = { "russia","germany", "france" };
        public int ShippingCost { get; set; } = 1500;
    }
}
