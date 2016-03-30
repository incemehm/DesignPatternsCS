using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class UrfaUsta : Usta
    {
        public override void SetKebapProperties()
        {
            kebap.ad = "Urfa Kebabı";
            kebap.aci = "Acısız";
            kebap.sos = "Sossuz";
        }
    }
}
