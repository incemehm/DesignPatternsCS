using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IHardwareFactory
    {
        IProcessor ProcessorModel();
        IRam RAMModel();
        IHdd HDDModel();
    }
}
