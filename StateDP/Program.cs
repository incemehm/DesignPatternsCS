using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Hava hava = new Hava();
            hava.Giyin();

            hava.DurumDegistir(new YagmurluHava());
            hava.Giyin();

            hava.DurumDegistir(new KarliHava());
            hava.Giyin();
        }
    }
}
