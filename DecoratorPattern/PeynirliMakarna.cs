using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class PeynirliMakarna : MakarnaDecorator
    {
        public PeynirliMakarna(IMakarna mak) : base(mak)
        {

        }

        public override void ServisEt()
        {
            makarna.ServisEt();
            Console.WriteLine("Makarna Servis ediliyor ve üzerine kızarmış peynir ekleniyor...");
        }
    }
}
