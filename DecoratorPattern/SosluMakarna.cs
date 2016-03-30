using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SosluMakarna : MakarnaDecorator
    {        
        public SosluMakarna(IMakarna mak) : base(mak)
        {
        }

        public override void ServisEt()
        {
            makarna.ServisEt();
            Console.WriteLine("Makarna Servis ediliyor ve üzerine sos ekleniyor...");
        } 
    }
}
