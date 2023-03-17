using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country
{
    internal interface ICountryProps
    {
        string Name { get; set; }
        int Population {  get; set; }

        string Continent { get; set; }

        //string Creature { get; set; }
    }
}
