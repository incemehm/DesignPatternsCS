using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    public class KingstonRam : IRam
    {
        public void IntegrateRAM()
        {
            Console.WriteLine("Kingston RAM entegre ediliyor...");
        }
    }
}
