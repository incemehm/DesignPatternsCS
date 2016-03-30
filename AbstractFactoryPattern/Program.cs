using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IHardwareFactory hardwareFactory = null;

            hardwareFactory = new HighPerformanceHardwareFactory();

            IProcessor processor = hardwareFactory.ProcessorModel();
            IRam ram = hardwareFactory.RAMModel();
            IHdd hdd = hardwareFactory.HDDModel();

            processor.IntegrateProcessor();
            ram.IntegrateRAM();
            hdd.IntegrateHDD();

            Console.WriteLine("-----------------------");

            hardwareFactory = new FairPriceHardwareFactory();

            processor = hardwareFactory.ProcessorModel();
            ram = hardwareFactory.RAMModel();
            hdd = hardwareFactory.HDDModel();

            processor.IntegrateProcessor();
            ram.IntegrateRAM();
            hdd.IntegrateHDD();
        }
    }
}
