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
        public int MaxWeight { get; set; } = 1500;
        public int MinWeight { get; set; } = 1000;
        public string[] CountryRestriction { get; set; } = {};
    }
}
