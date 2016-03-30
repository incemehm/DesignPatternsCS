using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class Kebap
    {
        public string ad { get; set; }
        public string aci { get; set; }
        public string sos { get; set; }

        public Kebap()
        { 
        
        }

        public override String ToString()
        {
            return "Kebap [ad=" + ad + ", aci=" + aci + ", sos=" + sos + "]";
        }
    }
}
