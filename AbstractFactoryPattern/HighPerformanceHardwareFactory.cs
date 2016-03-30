using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class HighPerformanceHardwareFactory : IHardwareFactory
    {
        public IProcessor ProcessorModel()
        {
            return new IntelProcessor();
        }

        public IRam RAMModel()
        {
            return new IbmRam();
        }

        public IHdd HDDModel()
        {
            return new ToshibaHDD();
        }
    }
}
