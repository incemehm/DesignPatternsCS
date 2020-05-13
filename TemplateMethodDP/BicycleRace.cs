namespace TemplateMethodDP
{
    public class BicycleRace : Race
    {
        protected override void TakeBreak()
        {
            System.Console.WriteLine("Drivers are taking a break.");
            System.Console.WriteLine("Drivers are drinking water.");
        }
    }
}
