using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class AdanaUsta : Usta
    {
        public override void SetKebapProperties()
        {
            kebap.ad = "Adana Kebabı";
            kebap.aci = "Acılı";
            kebap.sos = "Sossuz";
        }
    }
}
