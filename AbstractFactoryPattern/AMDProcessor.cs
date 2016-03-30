using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    public class AMDProcessor : IProcessor
    {
        public void IntegrateProcessor()
        {
            Console.WriteLine("AMD işlemci entegre ediliyor...");
        }
    }
}
