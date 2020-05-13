namespace MediatorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IAirport airport = new Airport();
            
            Airline flightLondon = new Lufthansa(airport, "LFT1919");
            Airline flightIstanbul = new Pegasus(airport, "PGS1881");
            Airline flightDubai = new Lufthansa(airport, "LFT1923");
            
            flightLondon.RequestLanding();
            System.Console.WriteLine("-----------------------");

            flightIstanbul.RequestLanding();
            System.Console.WriteLine("-----------------------");

            flightDubai.RequestLanding();
            System.Console.WriteLine("-----------------------");
        }
    }
}
