namespace DeliveryProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();

            order1.CheckOrderDetails(1000, "Germany");
        }
    }
}