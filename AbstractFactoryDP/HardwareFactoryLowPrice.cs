namespace AbstractFactoryDP
{
    public class HardwareFactoryLowPrice : IHardwareFactory
    {
        public IProcessor ProcessorModel()
        {
            return new ProcessorAMD();
        }

        public IRAM RAMModel()
        {
            return new RAMKingston();
        }
    }
}
