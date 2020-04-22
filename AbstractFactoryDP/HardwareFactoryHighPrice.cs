namespace AbstractFactoryDP
{
    public class HardwareFactoryHighPrice : IHardwareFactory
    {
        public IProcessor ProcessorModel()
        {
            return new ProcessorIntel();
        }

        public IRAM RAMModel()
        {
            return new RAMIBM();
        }
    }
}
