using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Yatirim yatirim = new Yatirim(new ATipiFon());
            double tutar = yatirim.GetiriHesapla(100);
            Console.WriteLine("A Tipi Fon getirisi: " + tutar);

            yatirim = new Yatirim(new BTipiFon());
            tutar = yatirim.GetiriHesapla(100);
            Console.WriteLine("B Tipi Fon getirisi: " + tutar);
        }
    }
}
