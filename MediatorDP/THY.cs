using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public class THY : HavayoluSirketi
    {
        public THY(Kule kule) : base(kule)
         {
             kule.THYLisansVer(this);
         }
   
        public override void InisIzniVer()
        {
            kule.THYInisIzniVer();
            Console.WriteLine("THY iniş izni verildi.");
        }

        public override void Beklet()
        {
            Console.WriteLine("THY bekletiliyor.");
        }
    }
}
