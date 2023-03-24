using System.Reflection.Metadata.Ecma335;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input var1: ");



            //Console.Write("Input something: ");

            //var var1 = "fdsfdsf";
            //bool checkV1 = false;
            //var var2 = "fdsfds";
            //bool checkV2 = false;


            //Check<string> check1 = new Check<string>();

            //check1.checkStr = new(check1.Meth1);
            //check1.checkStr += check1.Meth3;

            //check1.Start(ref var1, ref checkV1,ref var2,ref checkV2);
            //int[] intArr = { 1, 2, 3 };
            //double[] doubleArr = { 1.0, 2.0, 3.0 };
            //string[] strArr = { "1", "2", "3" };

            //DispArr(intArr);
            //DispArr(doubleArr);
            //DispArr(strArr);

            //GClass<Int32> Gclass = new GClass<Int32>();

            //Gclass.GetPropType();


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