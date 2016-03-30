using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ManisaUsta : Usta
    {
        public override void SetKebapProperties()
        {
            kebap.ad = "Manisa Kebabı";
            kebap.aci = "Acılı";
            kebap.sos = "Beşamel";
        }
    }
}
