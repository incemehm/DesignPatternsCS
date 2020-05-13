namespace MediatorDP
{
    public class Lufthansa : Airline
    {
        public Lufthansa(IAirport airport, string flightCode) : base(airport, flightCode)
        {
            airport.RegisterAirline(this);
        }

        public override void RequestLanding()
        {
            System.Console.WriteLine($"Lufthansa ({this.FlightCode}) requests landing permission!");

            airport.ManageLanding(this.FlightCode);            
        }

        public override void Allow()
        {
            System.Console.WriteLine($"Lufthansa ({this.FlightCode}) allowed!");
        }

        public override void Hold()
        {
            System.Console.WriteLine($"Lufthansa ({this.FlightCode}) on hold!");
        }
    }
}
