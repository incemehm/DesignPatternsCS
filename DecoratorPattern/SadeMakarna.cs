using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
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
