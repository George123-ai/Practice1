using System.Diagnostics;

namespace Sorting
{
    internal class Program
    {
        static int LinearSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

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
        } // Binary Search

        static int[] BubbleSortArray(int[] arr) // BubbleSort
        {
            //int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;  j < arr.Length-1;  j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int x = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = x;
                    }
                }
            }

            return arr;
        }

        static void PrintArr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} ");
            }
        }


        static void Main(string[] args)
        {
            int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            int index = LinearSearch(array,11);

            if(index != -1)
                Console.WriteLine($"Element found at index: {index}");
            else
                Console.WriteLine("Element not found!");


            //Console.WriteLine("Hello, World!");

            //int[] array = new int[100];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //    //Console.WriteLine(array[i]);
            //}
            //int target = 99;
            //int index = BinarySearch(array, target);

            //if(index == -1)
            //    Console.WriteLine($"{target} not found!");
            //else
            //    Console.WriteLine($"Target found at index: {index}");

            //int[] arr = new int[11];
            //Random rnd = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(0, 11);
            //}


            //PrintArr(arr);
            //Console.WriteLine();

            //PrintArr(BubbleSortArray(arr));

            //Stack<string> stack = new Stack<string>();

            //stack.Push("Bruce");
            //stack.Push("Peter");
            //stack.Push("Mike");

            //for (int i = 0; i < stack.Count; i++)
            //{
            //    Console.WriteLine(stack[i]);
            //}
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine($"if Georgy in stack : {stack.Contains("Georgy")}");


            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //// comment
            //stack.Pop();
            //Console.WriteLine();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}