using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    public class IntelProcessor : IProcessor
    {
        public void IntegrateProcessor()
        {
            Console.WriteLine("Intel işlemci entegre ediliyor...");
        }
    }
}
