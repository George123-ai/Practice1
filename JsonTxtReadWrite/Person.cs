using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTxtReadWrite
{
    internal class Person
    {
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; }

        public override string ToString()
        {
            return $"Name:{Name},Surname:{Surname}";
        }

    }
}
