namespace AbstractFactoryDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IHardwareFactory hardwareFactory = null;

            hardwareFactory = new HardwareFactoryHighPrice();

            IProcessor processor = hardwareFactory.ProcessorModel();
            IRAM ram = hardwareFactory.RAMModel();

            processor.IntegrateProcessor();
            ram.IntegrateRAM();

            System.Console.WriteLine("-----------------------");

            hardwareFactory = new HardwareFactoryLowPrice();

            processor = hardwareFactory.ProcessorModel();
            ram = hardwareFactory.RAMModel();

            processor.IntegrateProcessor();
            ram.IntegrateRAM();
        }
    }
}
