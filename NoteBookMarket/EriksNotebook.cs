using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookMarket
{
    internal class EriksNotebook : INotebook
    {
        private string brand = "Dell";
        public string Brand { get { return brand; } set { brand = value; } }

        public string SubBrand { get; set; }

        public double Weight { get; set; }
        public byte Ram { get; set; }
        public int count { get; set; }

        public void FirstAccelaration()
        {
            Console.WriteLine("Brand " + Brand);
            Console.WriteLine(" EriksNotebook: INotebook++ FirstAccelaration"); ;
        }

        
    }
}
