namespace PrototypeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dvd dvd = new Dvd("The Hobbit", "There and back again");

            System.Console.WriteLine(dvd);

            Dvd copyDvd = (Dvd)dvd.Clone();

            System.Console.WriteLine(copyDvd);
        }
    }
}
