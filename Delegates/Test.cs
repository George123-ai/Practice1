using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
    internal class Test
    {
        public delegate int Del1( ref int n);

        public Del1 NumberChange { get; set; }

        //public int n = 5000;

        //public int n { get; set; } = 5000;
        public int Method(ref int n)
        {
            Console.WriteLine(n);
            return n;
        }

        public int Method1(ref int n)
        {
            n -= 500;
            Console.WriteLine(n);
            return n;
        }

        public int Method2(ref int n)
        {
            n += 200;
            Console.WriteLine(n);
            return n;
        }

        public int Start()
        {
            int n = 5000;
            return NumberChange(ref n);
        }

        
       
        
    }
}
