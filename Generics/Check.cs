using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Check<T>
    {

        public delegate bool CheckStrDelegate(ref T var , ref bool check);

        public CheckStrDelegate checkStr { get; set; }

        public bool Meth1(ref T var1 , ref bool check1) //ref T var2, ref bool check2 )
        {
            check1 = false;
            if (var1.GetType() == typeof(string))
                check1 = true;

            Console.WriteLine($"Check1 = {check1}");

            return check1;
             
        }

        public bool Meth2(ref T var2, ref bool check2)
        {
            check2 = false;
            if (var2.GetType() == typeof(string))
                check2 = true;

            Console.WriteLine($"Check2 = {check2}");

            return check2;

        }

        public void Meth3(ref T var1, ref T var2, ref bool check1, ref bool check2)
        {
           
        }

        public void Start(ref T var, ref bool check)
        {
            checkStr(ref var,ref check);
            //checkStr = new(Meth1);
            //checkStr += Meth2;
           // checkStr.Invoke();
            
        }
    }
}
