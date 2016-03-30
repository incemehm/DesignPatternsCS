using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public class Lufthansa : HavayoluSirketi
    {
         public Lufthansa( Kule kule ): base(kule)
         {
             kule.LufthansaLisansVer(this);
         }

        public override void InisIzniVer()
         {
             kule.LufthansaInisIzniVer();
            Console.WriteLine("Lufthansa iniş izni verildi.");
        }

        public override void Beklet()
        {
            Console.WriteLine("Lufthansa bekletiliyor.");
        }
    }
}
