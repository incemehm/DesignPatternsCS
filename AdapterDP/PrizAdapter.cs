using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    public class PrizAdapter : Priz
    {
        private IngilizPriz adapted = new IngilizPriz();

        public override void Connect()
        {
            adapted.Connect3Pin();
        } 


    }
}
