using System.Data;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            //ChangeValue(num1);
            //Console.WriteLine(num1);

            int num2 = ChangeValue(ref num1);
            Console.WriteLine(num2);

            ChangeValue1(out num1);
            Console.WriteLine(num1);

            ChangeValue1(out int num3);
            Console.WriteLine(num3);

            int num4 = 5;
            ChangeValue2(num4);
            
        }

        static int ChangeValue(ref int value)
        {
            value++;
            return value;
        }

        static void ChangeValue1(out int value)
        {
            value = 100;
        }

        static void ChangeValue2(in int value)
        {
            Console.WriteLine(value);
        }

        
    }
}