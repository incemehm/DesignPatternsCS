using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    public class FairPriceHardwareFactory : IHardwareFactory
    {
        public IProcessor ProcessorModel()
        {
            return new AMDProcessor();
        }

        public IRam RAMModel()
        {
            return new KingstonRam();
        }

        public IHdd HDDModel()
        {
            return new SamsungHDD();
        }
    }
}
