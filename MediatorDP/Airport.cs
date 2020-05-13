using System.Collections.Generic;
using System.Linq;

namespace MediatorDP
{
    public class Airport : IAirport
    {
        private Dictionary<string, Airline> flights;

        public Airport()
        {
            flights = new Dictionary<string, Airline>();
        }
        
        public void RegisterAirline(Airline airline)
        {
            if (!flights.ContainsValue(airline))
                flights[airline.FlightCode] = airline;
        }

        public void ManageLanding(string flightCode)
        {
            foreach (string _flightCode in flights.Keys.Where(x => x != flightCode))
            {
                flights[_flightCode].Hold();
            }

            flights[flightCode].Allow();
        }
    }
}
