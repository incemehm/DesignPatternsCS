using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public interface IBildirim
    {
        void TakipcilereBildir();
        void TakipciEkle(ITakipci takipci);
    }
}
