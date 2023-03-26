using System.Diagnostics;

namespace Sorting
{
    internal class Program
    {
        static int BinarySearch(int[] array , int target)
        {
            int step = 1;
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int middle = low + (high - low) / 2;
                int value = array[middle];
                
                Console.WriteLine($"middle: {value} , step: {step}");
                step++;
                if (value < target)
                    low = middle + 1;
                else if (value > target)
                    high = middle - 1;
                else
                    return middle;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                //Console.WriteLine(array[i]);
            }
            int target = 99;
            int index = BinarySearch(array, target);

            if(index == -1)
                Console.WriteLine($"{target} not found!");
            else
                Console.WriteLine($"Target found at index: {index}");
        }
    }
}