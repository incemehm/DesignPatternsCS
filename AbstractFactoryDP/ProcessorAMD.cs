using System;

namespace AbstractFactoryDP
{
    public class ProcessorAMD : IProcessor
    {
        public void IntegrateProcessor()
        {
            Console.WriteLine("AMD processor is being intregrated...");
        }
    }
}
