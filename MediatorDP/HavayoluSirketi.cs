using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public abstract class HavayoluSirketi
    {
         protected Kule  kule;

         public HavayoluSirketi(Kule kule)
         {
             this.kule = kule;
         }

          public abstract void InisIzniVer();

          public abstract void Beklet();
    }
}
