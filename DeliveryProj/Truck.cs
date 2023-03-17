using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProj
{
    internal class Truck : ITransport
    {
        public string ShipTime { get; set; } = "1 month";
        public int MaxWeight { get; set; } = 600;
        public int MinWeight { get; set; } = 0;
        public string[] CountryRestriction { get; set; } = { "USA", "England", "Australia" };
    }
}
