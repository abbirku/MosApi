using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MosApiTest3.ViewModel
{
    public class GetFlightAvailibilityRequest
    {
        public int NoofAdult { get; set; }
        public int NoofChild { get; set; }
        public int NoofInfant { get; set; }
        public string FromAirportCode { get; set; }
        public string ToAirportCode { get; set; }
        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
        public int TripType { get; set; }
        public string FlightClass { get; set; }
        public int SpecialFare { get; set; }
        public string PreferedAirlines { get; set; }
        public string AirlineType { get; set; }
    }
}