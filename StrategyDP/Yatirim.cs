using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class Yatirim
    {
        private IFon  birim;

        public Yatirim(IFon birim)
        {
            this.birim = birim;
        }

        public double GetiriHesapla(double tutar)
        {
           return birim.Hesapla(tutar);
        }
    }
}
