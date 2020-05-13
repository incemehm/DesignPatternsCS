namespace MediatorDP
{
    public interface IAirport
    {
        void RegisterAirline(Airline airline);
        void ManageLanding(string flightCode);
    }
}
