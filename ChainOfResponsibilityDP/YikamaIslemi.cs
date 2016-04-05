using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    public class YikamaIslemi : Islem
    {
        protected override void IsYap(Makina makina)
        {
            makina.Durum = 2;
            Console.WriteLine("Yikama islemi yapildi... Makina Durumu = " + makina.Durum);
        }
    }
}
