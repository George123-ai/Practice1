using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProj
{
    internal class Order:IDelivery
    {
        public string ShippingTime { get; set; }
        public long TrackingId { get; set; }
        public decimal ShippingCost { get; set; }
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
                {
                    Console.WriteLine("Order can be shipped by: truck");
                    ShippingTime = truck.ShipTime;
                    Console.WriteLine($"Delivery period by truck : {ShippingTime}");
                    ShippingCost = truck.ShippingCost;
                    Console.WriteLine($"Shipping cost(kg) = {ShippingCost} dram");
                    Console.WriteLine();
                }
                    
                if (orderWeight >= airplane.MinWeight && orderWeight <= airplane.MaxWeight)
                {
                    Console.WriteLine(" Order can be shipped by : airplane.");
                    ShippingTime = airplane.ShipTime;
                    Console.WriteLine($"Delivery period by airplane : {ShippingTime}");
                    ShippingCost = airplane.ShippingCost;
                    Console.WriteLine($"Shipping cost(kg) = {ShippingCost} dram");

                }

            }
            else if (truck.CountryRestriction.Contains(orderCountry))
            {
                if (orderWeight >= ship.MinWeight && orderWeight <= ship.MaxWeight)
                {
                    Console.Write("Order can be shipped by: ship, ");
                    ShippingTime = ship.ShipTime;
                    Console.WriteLine($"Delivery period by ship : {ShippingTime}");
                    ShippingCost = ship.ShippingCost;
                    Console.WriteLine($"Shipping cost(kg) = {ShippingCost} dram");
                    Console.WriteLine();
                }
                if (orderWeight >= airplane.MinWeight && orderWeight <= airplane.MaxWeight)
                {
                    Console.WriteLine(" Order can be shipped by : airplane.");
                    ShippingTime = airplane.ShipTime;
                    Console.WriteLine($"Delivery period by airplane : {ShippingTime}");
                    ShippingCost = airplane.ShippingCost;
                    Console.WriteLine($"Shipping cost(kg) = {ShippingCost} dram");

                }

            }
            else if (airplane.CountryRestriction.Contains(orderCountry))
            {
                if (orderWeight >= truck.MinWeight && orderWeight <= truck.MaxWeight)
                {
                    Console.WriteLine("Order can be shipped by: truck");
                    ShippingTime = truck.ShipTime;
                    Console.WriteLine($"Delivery period by truck : {ShippingTime}");
                    ShippingCost = truck.ShippingCost;
                    Console.WriteLine($"Shipping cost(kg) = {ShippingCost} dram");
                    Console.WriteLine();
                }

                if (orderWeight >= ship.MinWeight && orderWeight <= ship.MaxWeight)
                {
                    Console.Write("Order can be shipped by: ship, ");
                    ShippingTime = ship.ShipTime;
                    Console.WriteLine($"Delivery period by ship : {ShippingTime}");
                    ShippingCost = ship.ShippingCost;
                    Console.WriteLine($"Shipping cost(kg) = {ShippingCost} dram");
                }

            }
            else
            {
                if (orderWeight >= truck.MinWeight && orderWeight <= truck.MaxWeight)
                {
                    Console.WriteLine("Order can be shipped by: truck");
                    ShippingTime = truck.ShipTime;
                    Console.WriteLine($"Delivery period by truck : {ShippingTime}");
                    ShippingCost = truck.ShippingCost;
                    Console.WriteLine($"Shipping cost(kg) = {ShippingCost} dram");
                    Console.WriteLine();
                }
                if (orderWeight >= airplane.MinWeight && orderWeight <= airplane.MaxWeight)
                {
                    Console.WriteLine(" Order can be shipped by : airplane.");
                    ShippingTime = airplane.ShipTime;
                    Console.WriteLine($"Delivery period by airplane : {ShippingTime}");
                    ShippingCost = airplane.ShippingCost;
                    Console.WriteLine($"Shipping cost(kg) = {ShippingCost} dram");
                    Console.WriteLine();
                }
                if (orderWeight >= ship.MinWeight && orderWeight <= ship.MaxWeight)
                {
                    Console.Write("Order can be shipped by: ship, ");
                    ShippingTime = ship.ShipTime;
                    Console.WriteLine($"Delivery period by ship : {ShippingTime}");
                    ShippingCost = ship.ShippingCost;
                    Console.WriteLine($"Shipping cost(kg) = {ShippingCost} dram");
                }

            }


        }
    }
}
