using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    public class DurulamaIslemi : Islem
    {
        protected override void IsYap(Makina makina)
        {
            makina.Durum = 3; //Islem bitti mesela
            Console.WriteLine("Durulama islemi yapildi... Makina Durumu = " + makina.Durum);
        }
    }
}
