using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SadeMakarna : IMakarna
    {
        public SadeMakarna()
        {

        }

        public void ServisEt()
        {
            Console.WriteLine("Sade makarna servis ediliyor...");
        } 
    }
}
