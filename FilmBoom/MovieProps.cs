﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal interface MovieProps
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Actors { get; set; }
    }
}
