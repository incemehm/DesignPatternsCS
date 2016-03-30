using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kule kule = new Kule();

            HavayoluSirketi[] sirketler = new HavayoluSirketi[2];
            sirketler[0] = new THY(kule);
            sirketler[1] = new Lufthansa(kule);

            sirketler[0].InisIzniVer();
            sirketler[1].InisIzniVer();

        }
    }
}
