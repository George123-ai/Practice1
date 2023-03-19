namespace Delegates
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            ExchangeMonitoring exchangeMonitoring = new ExchangeMonitoring();
            //exchangeMonitoring.PriceChangeHandler = ShowPrice;

            //exchangeMonitoring.Start();

            Test test = new Test();

            test.NumberChange = new(test.Method);

            test.NumberChange += test.Method1;

            test.NumberChange += test.Method2;

            test.Start();


            //Console.WriteLine(test.Start());

        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price is {price}");
        }
    }
}