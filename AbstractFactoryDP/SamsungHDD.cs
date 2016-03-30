using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    public class SamsungHDD : IHdd
    {
        public void IntegrateHDD()
        {
            Console.WriteLine("Samsung HDD entegre ediliyor...");
        }
    }
}
