using System.Runtime.CompilerServices;

namespace DeliveryProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            int orderWeight;
            string orderCountry;

            Console.Write("Enter order weight: ");
            orderWeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ordering country: ");
            orderCountry = Console.ReadLine();

            order1.CheckOrderDetails(orderWeight, orderCountry);
        }
    }
}