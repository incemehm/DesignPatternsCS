namespace MementoDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor monitor = new Monitor();

            ScreenSaver screenSaver = new ScreenSaver() { Theme = "Colorful Spring", TimeInterval = 60 };

            monitor.LastActiveState = screenSaver.Save();

            System.Console.WriteLine("Current theme: " + screenSaver.Theme);
            System.Console.WriteLine("Last theme: " + monitor.LastActiveState.Theme);
            System.Console.WriteLine("-----------------------");

            screenSaver.Theme = "Black Clouds";

            System.Console.WriteLine("Current theme: " + screenSaver.Theme);
            System.Console.WriteLine("Last theme: " + monitor.LastActiveState.Theme);
            System.Console.WriteLine("-----------------------");

            System.Console.WriteLine("Restoring last theme!");
            screenSaver.Restore(monitor.LastActiveState);

            System.Console.WriteLine("Current theme: " + screenSaver.Theme);
            System.Console.WriteLine("Last theme: " + monitor.LastActiveState.Theme);
            System.Console.WriteLine("-----------------------");

        }
    }
}
