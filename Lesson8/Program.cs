namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            Random rnd = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    numberList.Add(rnd.Next(10,100));
            //    Console.WriteLine(numberList[i]);
            //}


             Dictionary<int, string> dictionary1 = new Dictionary<int, string>()
            {
                {1, "Georgy" },
                {2, "Erik" }
            };

            

            foreach (var item in dictionary1)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }


            //foreach (var item in numberList)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}