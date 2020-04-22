using System;

namespace SingletonDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vodafone line = Vodafone.GetInstance();
            string name = line.GetName();
            int number = line.GetNumber();

            Console.WriteLine("Name: " + name + ", number: " + number);

            VodafoneLazy lineLazy = VodafoneLazy.GetInstance();
            string name2 = lineLazy.GetName();
            int number2 = lineLazy.GetNumber();

            Console.WriteLine("Name: " + name2 + ", number: " + number2);

        }
    }
}
