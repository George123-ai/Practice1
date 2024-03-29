﻿using System.ComponentModel.Design;
using System.Diagnostics;

namespace DataStructures
{
    internal class Program
    {
        //---------------------------------
        static void InserionSort(int[] arr) // Insertion sort Quadratic time O(n^2),large data set = BAD,
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }

        static void SelectionSort(int[] arr) // Selection sort Quadratic time O(n^2), large data set = BAD
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                        min = j;
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
        
        static int InterpolationSearch(int[] array, int value)
        {
            int high = array.Length - 1;
            int low = 0;

            while (value >= array[low] && value <= array[high] && low <= high)
            {
                int test = low + (high - low) * (value - array[low]) /
                    (array[high] - array[low]);

                //Console.WriteLine($"Test: " + test);

                if (array[test] == value)
                    return test;
                else if (array[test] < value)
                    low = test + 1;
                else
                    high = test - 1;

            }

            return -1;
        } // Interpolation search

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
        } // linear search

        static int BinarySearch(int[] array, int target)
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

        static int[] BubbleSortArray(int[] arr) // BubbleSort Quadratic time O(n^2), large data set = BAD
        {
            //int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
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
            int[] array = { 9, 1, 8, 2, 7, 3, 6, 5, 4 };

            InserionSort(array);

            PrintArr(array);

            //int[] array = { 8, 9, 7, 2, 3, 1, 5, 4, 6 };

            //SelectionSort(array);

            //PrintArr(array);
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int index = interpolationSearch(array, 1);

            //if (index != -1)
            //{
            //    Console.WriteLine($"Element found at index: {index}");
            //}
            //else
            //    Console.WriteLine("Element not found!");
            //int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            //int index = LinearSearch(array,11);

            //if(index != -1)
            //    Console.WriteLine($"Element found at index: {index}");
            //else
            //    Console.WriteLine("Element not found!");


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