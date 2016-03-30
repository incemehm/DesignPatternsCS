using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Not
    {
        private string harf;

        public Not(string harf)
        {
            this.harf = harf;
        }

        public void PrintNot()
        {
            switch (harf)
            { 
                case "AA":
                    Console.WriteLine("HARF NOTU:" + harf + " RAKAM: 4.00");
                    break;
                case "BA":
                    Console.WriteLine("HARF NOTU:" + harf + " RAKAM: 3.50");
                    break;
                case "BB":
                    Console.WriteLine("HARF NOTU:" + harf + " RAKAM: 3.00");
                    break;
                case "CB":
                    Console.WriteLine("HARF NOTU:" + harf + " RAKAM: 2.50");
                    break;
                case "CC":
                    Console.WriteLine("HARF NOTU:" + harf + " RAKAM: 2.00");
                    break;
                case "FF":
                    Console.WriteLine("HARF NOTU:" + harf + " RAKAM: 0.00");
                    break;
                default:
                    break;


            }
        }
    }
}
