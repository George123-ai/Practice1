using System.Collections.Immutable;
using System.Data;

namespace Practice1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Doctor doctor = new Doctor();
            ////doctor.Age = 10;
            //doctor.Testmethod();
            //Console.WriteLine(doctor.Age);

            //HumanBase humanBase = new HumanBase();
            //Console.WriteLine(humanBase.Age);\

            Doctor doctorParam= new Doctor(8);
            doctorParam.Testmethod();
            Console.WriteLine(doctorParam.Age + " doctorParam");

            HumanBase humanBase = new HumanBase();
            Console.WriteLine(humanBase.Age);

            //int[] sequence = { 1, 3, 2 };
            //int count = 0;
            //for (int i = 0; i < sequence.Length; i++)
            //{
            //    if (i == sequence.Length - 1)
            //        break;
            //    if ( sequence[i] == sequence[i + 1] || sequence[i + 1] != sequence[i] + 1)
            //    {
            //        Console.WriteLine(sequence[i]);
            //        Console.WriteLine(sequence[i+1]);
            //        count++;
            //    }
            //}
            
            //if (count > 1)
            //    Console.WriteLine(false);
            //else
            //    Console.WriteLine(true);
            
            //int[] numbers = { 1,3,5,1 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($" {numbers[i]} ");
            //}
            //Console.WriteLine();


            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($" {numbers[i]} ");
            //}
            //Console.WriteLine();
            //int num1 = 5;
            ////ChangeValue(num1);
            ////Console.WriteLine(num1);

            //int num2 = ChangeValue(ref num1);
            //Console.WriteLine(num2);

            //ChangeValue1(out num1);
            //Console.WriteLine(num1);

            //ChangeValue1(out int num3);
            //Console.WriteLine(num3);

            //int num4 = 5;
            //ChangeValue2(num4);

            //PrintMessage(DayTime.Morning);
            //Console.WriteLine(DayTime.Evening);

            //dynamic num5;

            //num5 = 10;
            //Console.WriteLine(num5);

            //num5 = "I'am dynamic , I can change my data type:]";

            //Console.WriteLine(num5);

            //var something = 15;
            //var something1 = "string";

            //Console.WriteLine(something.GetType());
            //Console.WriteLine(something1.GetType());

        }  

        //static int ChangeValue(ref int value)
        //{
        //    value++;
        //    return value;
        //}

        //static void ChangeValue1(out int value)
        //{
        //    value = 100;
        //}

        //static void ChangeValue2(in int value)
        //{
        //    Console.WriteLine(value);
        //}

        //static void PrintMessage(DayTime dayTime)
        //{
        //    switch (dayTime)
        //    {
        //        case DayTime.Morning:
        //            Console.WriteLine("Good morning!");
        //            break;
        //        case DayTime.Afternoon:
        //            Console.WriteLine("Good afternoon!");
        //            break;
        //        case DayTime.Evening:
        //            Console.WriteLine("Good evening!");
        //            break;
        //        case DayTime.Night:
        //            Console.WriteLine("Good night!");
        //            break;
        //    }
        //}
        //enum DayTime
        //{
        //    Morning,
        //    Afternoon,
        //    Evening,
        //    Night
        //}

        //static public int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        //static public int Sum(int num1, int num2, int num3)
        //{
        //    return num1 + num2 + num3;
        //}
        //static public int Sum(int num1, int num2, int num3, int num4)
        //{
        //    return num1 + num2 + num3 + num4;
        //}
        //static public void Sum()
        //{
        //    Console.WriteLine("Hello eho");
        //}

        //static public double Sum(double num1, double num2)
        //{
        //    return num1 + num2;
        //}
        //static public double Sum(double num1, double num2, double num3)
        //{
        //    return num1 + num2 + num3;
        //}
        //static public double Sum(double num1, double num2, double num3, double num4)
        //{
        //    return num1 + num2 + num3 + num4;
        //}



    }
}