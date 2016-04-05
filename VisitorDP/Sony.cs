using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDP
{
    public class Sony : Telefon
    {
        public override void GecisYap(IBaglanti baglanti)
        {
            baglanti.Gec(this);
        }
    }
}
