namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[101];
            int x = 24;
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = i;
                Console.WriteLine(numbers[i]);
            }

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //}
            int half = numbers[(numbers.Length - 1) / 2];
            //Console.WriteLine("/////////////" + half / 2 / 2);
            if (half > x) // 50 > 24 --> true
            {
                if (half/2 > x) // 25 > 24 --> true
                {
                    if (half/2/2 > x) // 12 > 24 --> false
                    {

                    }
                    else if(half/2/2 == x)
                    {
                        Console.WriteLine($" index: {x}, value: {numbers[x]}");
                    }
                    else
                    {
                        if ((half/2/2)*2 > x)
                        {

                        }
                        else if((half/2/2)*2 == x)
                        {
                            Console.WriteLine($" index: {x}, value: {numbers[x]}");
                        }
                    }
                }
                else if (half == x)
                {
                    Console.WriteLine($" index: {x}, value: {numbers[x]}");
                }
            }
            else if(half== x)
            {
                Console.WriteLine($" index: {x}, value: {numbers[x]}");
            }

            
        }
    }
}