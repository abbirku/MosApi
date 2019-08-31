using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MosApiTest3.ViewModel
{
    public class FlightAvailibilityResponse
    {
        public GetFlightAvailibilityResponse GetFlightAvailibilityResponse { get; set; }
    }

    public class GetFlightAvailibilityResponse
    {
        public IEnumerable<FlightDetail> FlightDetails { get; set; }

        public IEnumerable<FareDetail> FareDetails { get; set; }

        public IEnumerable<Airline> AirlineList { get; set; }

        public IEnumerable<Airport> AirportList { get; set; }
    }
}