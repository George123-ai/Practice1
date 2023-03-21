using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GClass<T>
    {

        public T Value { get; set; }

        public void GetPropType()
        {
            Console.WriteLine(Value.GetType());
        }
    }
}
