using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    public class ToshibaHDD : IHdd
    {
        public void IntegrateHDD()
        {
            Console.WriteLine("Toshiba HDD entegre ediliyor...");
        }
    }
}
