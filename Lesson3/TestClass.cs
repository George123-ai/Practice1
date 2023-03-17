using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class TestClass: VirtualClass
    {
        public override void VirtualEmptyMethod()
        {
            
            Console.WriteLine("TestClass: VirtualClass");
            base.VirtualEmptyMethod();
            Console.WriteLine("Ending VirtualEmptyMethod");
        }

        public override int VirtualMethod(int y)
        {
            return base.VirtualMethod(y);
        }

        public TestClass(int t)
        {
            base.VirtualMethod(t);
        }

        public TestClass()
        {

        }
    }
}
