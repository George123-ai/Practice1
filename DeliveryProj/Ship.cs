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
        public int MaxWeight { get; set; } = 4000;
        public int MinWeight { get; set; } = 1000;
        public string[] CountryRestriction { get; set; } = { "Russia","Eauropean countries" };
    }
}
