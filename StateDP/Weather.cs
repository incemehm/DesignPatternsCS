namespace StateDP
{
    public class Weather
    {
        private IWeatherState weatherState;

        public Weather()
        {
            weatherState = new SunnyWeather();
        }

        public void WearSomething()
        {
            weatherState.ChooseRightDress();
        }

        public void ChangeWeatherState(IWeatherState weatherState)
        {
            this.weatherState = weatherState;
        }
    }
}
