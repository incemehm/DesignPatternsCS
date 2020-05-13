namespace MediatorDP
{
    public abstract class Airline
    {
        protected IAirport airport;
        public string FlightCode { get; }

        public Airline(IAirport airport, string flightCode)
        {
            this.airport = airport;
            this.FlightCode = flightCode;
        }

        public abstract void RequestLanding();

        public abstract void Allow();

        public abstract void Hold();
    }
}
