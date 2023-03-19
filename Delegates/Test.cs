using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
    internal class Test
    {
        //public int n { get; set; } = 5000;
        public int Method(ref int n)
        {
            //n = n;
            return n;
        }

        public int Method1(ref int n)
        {
            return n - 500;
        }

        public int Method2(ref int n)
        {
            return n + 200;
        }
        public delegate int Del1(ref int n);

        public Del1 del1;

        
       
        
    }
}
