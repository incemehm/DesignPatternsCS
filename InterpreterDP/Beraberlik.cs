using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDP
{
    public class Beraberlik : ISonuc
    {
        public void PuanHesapla(Takim takim)
        {
            takim.Puan += 1;
        }
    }
}
