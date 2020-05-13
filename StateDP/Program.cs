namespace StateDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather();
            weather.WearSomething();

            weather.ChangeWeatherState(new RainyWeather());
            weather.WearSomething();

            weather.ChangeWeatherState(new SnowyWeather());
            weather.WearSomething();
        }
    }
}
