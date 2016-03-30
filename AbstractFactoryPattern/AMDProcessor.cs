using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class AMDProcessor : IProcessor
    {
        public void IntegrateProcessor()
        {
            Console.WriteLine("AMD işlemci entegre ediliyor...");
        }
    }
}
