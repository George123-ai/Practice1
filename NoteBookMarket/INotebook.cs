using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookMarket
{
    internal interface INotebook
    {
        public string Brand { get; set; }

        public string SubBrand { get; set; }

        public double Weight { get; set; }

        public byte Ram { get; set; }

        int count { get; set; }

        public void FirstAccelaration();
      

        public void SecondAccelaration(int t)
        {
            Console.WriteLine(t);
        }

    }
}
