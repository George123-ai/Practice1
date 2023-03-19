using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class ExchangeMonitoring
    {
        public delegate void PriceChange(int price);

        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while (true)
            {
                int bankOfRussiaPrice = (new Random()).Next(100);

                PriceChangeHandler(bankOfRussiaPrice);

                Thread.Sleep(2000);
            }
        }
    }
}
