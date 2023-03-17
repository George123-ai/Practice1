using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProj
{
    internal class Order:IDelivery
    {
        public int ShippingTime { get; set; }
        public long TrackingId { get; set; }
        public decimal ShippingCoust { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal Sale { get; set;}

        public void CheckOrderDetails(int orderWeight,string orderCountry)
        {
            Ship ship = new Ship(); 
            Truck truck = new Truck();
            Airplane airplane = new Airplane();

            orderCountry = orderCountry.ToLower();

            if (ship.CountryRestriction.Contains(orderCountry))
            {
                if (orderWeight >= truck.MinWeight && orderWeight <= truck.MaxWeight)
                    Console.Write("Order can be shipped by: truck, ");
                if (orderWeight >= airplane.MinWeight && orderWeight <= airplane.MaxWeight)
                    Console.Write(" airplane. \n");
            }
            else if (truck.CountryRestriction.Contains(orderCountry))
            {
                if (orderWeight >= ship.MinWeight && orderWeight <= ship.MaxWeight)
                    Console.Write("Order can be shipped by: ship, ");
                if (orderWeight >= airplane.MinWeight && orderWeight <= airplane.MaxWeight)
                    Console.Write(" airplane.\n");
            }
            else if (airplane.CountryRestriction.Contains(orderCountry))
            {
                if (orderWeight >= truck.MinWeight && orderWeight <= truck.MaxWeight)
                    Console.Write("Order can be shipped by: truck, ");
                if (orderWeight >= ship.MinWeight && orderWeight <= ship.MaxWeight)
                    Console.Write(" airplane. \n");
            }
            //for (int i = 0; i < ship.CountryRestriction.Length; i++)
            //{
            //    if (orderCountry.ToLower() == ship.CountryRestriction[i].ToLower())
            //    {
            //        if (orderWeight >= truck.MinWeight && orderWeight <= truck.MaxWeight)
            //            Console.Write("Order can be shipped by: truck, ");
            //        if (orderWeight >= airplane.MinWeight && orderWeight <= airplane.MaxWeight)
            //            Console.Write(" airplane\n");
            //    }
            //}


        }
    }
}
