using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Check<T>
    {

        public delegate void CheckStrDelegate(ref T var , ref bool check, ref T var2, ref bool check2);

        public CheckStrDelegate checkStr { get; set; }

        public void Meth1(ref T var1 , ref bool check1, ref T var2, ref bool check2) //ref T var2, ref bool check2 )
        {
            check1 = false;
            if (var1.GetType() == typeof(string))
                check1 = true;

            Console.WriteLine($"Check1 = {check1}");

            check2 = false;
            if (var2.GetType() == typeof(string))
                check2 = true;

            Console.WriteLine($"Check2 = {check2}");
        }

        //public bool Meth2(ref T var2, ref bool check2)
        //{
        //    check2 = false;
        //    if (var2.GetType() == typeof(string))
        //        check2 = true;

        //    Console.WriteLine($"Check2 = {check2}");

        //    return check2;

        //}

        public void Meth3(ref T var1, ref bool check1,ref T var2, ref bool check2)
        {
            if ((check1==true) && (check2==true))
            {
                Console.WriteLine($"{var1}{var2}");
            }
            else
            {
                Console.WriteLine("OOPS...");
            }
        }

        public void Start(ref T var, ref bool check, ref T var2, ref bool check2)
        {
            checkStr(ref var,ref check, ref var2, ref check2);
            //checkStr = new(Meth1);
            //checkStr += Meth2;
           // checkStr.Invoke();
            
        }
    }
}
