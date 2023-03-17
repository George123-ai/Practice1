using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProj
{
    internal class Airplane : ITransport
    {
        public string ShipTime { get; set; } = "1-9 days";
        public int MinWeight { get; set; } = 1000;
        public int MaxWeight { get; set; } = 3000;
        public string[] CountryRestriction { get; set; } = {};
        public int ShippingCost { get; set; } = 6000;
    }
}
