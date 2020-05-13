namespace MediatorDP
{
    public class Pegasus : Airline
    {
        public Pegasus(IAirport airport, string flightCode) : base(airport, flightCode)
        {
            airport.RegisterAirline(this);
        }

        public override void RequestLanding()
        {
            System.Console.WriteLine($"Pegasus ({this.FlightCode}) requests landing permission!");

            airport.ManageLanding(this.FlightCode);
        }

        public override void Allow()
        {
            System.Console.WriteLine($"Pegasus ({this.FlightCode}) allowed!");
        }

        public override void Hold()
        {
            System.Console.WriteLine($"Pegasus ({this.FlightCode}) on hold!");
        }
    }
}
