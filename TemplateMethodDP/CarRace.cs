namespace TemplateMethodDP
{
    public class CarRace : Race
    {
        protected override void TakeBreak()
        {
            System.Console.WriteLine("Drivers are taking a break.");
            System.Console.WriteLine("Drivers are changing wheels of cars.");
            System.Console.WriteLine("Drivers are filling gas to cars.");
        }
    }
}
