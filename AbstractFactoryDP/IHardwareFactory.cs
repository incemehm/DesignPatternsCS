namespace AbstractFactoryDP
{
    public interface IHardwareFactory
    {
        IProcessor ProcessorModel();
        IRAM RAMModel();
    }
}
