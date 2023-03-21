using System.Reflection.Metadata.Ecma335;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] intArr = { 1, 2, 3 };
            //double[] doubleArr = { 1.0, 2.0, 3.0 };
            //string[] strArr = { "1", "2", "3" };

            //DispArr(intArr);
            //DispArr(doubleArr);
            //DispArr(strArr);

            GClass<Int32> Gclass = new GClass<Int32>();

            Gclass.GetPropType();


        }

        static void DispArr<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
        }
        
        //static void DispArr(int[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.Write($" {item} ");
        //    }
        //    Console.WriteLine();
        //}

        //static void DispArr(double[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.Write($" {item} ");
        //    }
        //    Console.WriteLine();
        //}

        //static void DispArr(string[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.Write($" {item} ");
        //    }
        //    Console.WriteLine();
        //}
    }
}