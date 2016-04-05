using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    public class SuAlmaIslemi : Islem
    {
        protected override void IsYap(Makina makina)
        {
            makina.Durum = 1;
            Console.WriteLine("Su alma islemi yapildi... Makina Durumu = " + makina.Durum);
        }
    }
}
