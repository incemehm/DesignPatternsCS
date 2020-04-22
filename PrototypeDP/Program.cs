using System;

namespace PrototypeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dvd dvd = new Dvd("The Hobbit", "There and back again");

            Console.WriteLine(dvd);

            Dvd copyDvd = (Dvd)dvd.Clone();

            Console.WriteLine(copyDvd);
        }
    }
}
