namespace TemplateMethodDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new BicycleRace();
            race.TakeTour();

            race = new CarRace();
            race.TakeTour();
        }
    }
}
