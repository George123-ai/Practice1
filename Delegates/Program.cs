namespace Delegates
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            ExchangeMonitoring exchangeMonitoring = new ExchangeMonitoring();
            exchangeMonitoring.PriceChangeHandler = ShowPrice;

            exchangeMonitoring.Start();

        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price is {price}");
        }
    }
}