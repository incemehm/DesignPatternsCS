using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class ATipiFon : IFon
    {
        public double Hesapla(double tutar)
        {
            return tutar * 1.45;
        }
    }
}
