using System;

namespace AbstractFactoryDP
{
    public class ProcessorIntel : IProcessor
    {
        public void IntegrateProcessor()
        {
            Console.WriteLine("Intel processor is being intregrated...");
        }
    }
}
