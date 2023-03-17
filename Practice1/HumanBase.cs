using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class HumanBase
    {
        public HumanBase() { }

        public HumanBase(short age)
        {
            Age = age;
        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public short Age { get; set; }

        public GenderEnum Gender { get; set; }

        private string Test { get; set; }

        public void publicHelloMen() => Console.WriteLine("Hello chuvak");

        internal void internalByeMen() => Console.WriteLine("Bye chuvak");

        protected void protectedWhyMen() => Console.WriteLine("protected chuvak");

        private void _privateWhyMen() => Console.WriteLine("private chuvak");
    }

    public enum GenderEnum
    {
        Boy,
        Girl,
        Esiminch
    }
}
