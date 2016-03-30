using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] harfler = new string[] { "AA", "BA", "BB", "AA", "CC", "FF", "FF", "BB", "CC" };
            NotHavuzu havuz = new NotHavuzu();

            foreach (string harf in harfler)
            {
                Not not = havuz.GetNot(harf);
                not.PrintNot();
            }
        }
    }
}
