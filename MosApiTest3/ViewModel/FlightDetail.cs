using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MosApiTest3.ViewModel
{
    public class FlightDetail
    {
        public string SrNo { get; set; }
        public string AirlineCode { get; set; }
        public string FlightNo { get; set; }
        public string FromAirportCode { get; set; }
        public string ToAirportCode { get; set; }
        public string DepDate { get; set; }
        public string DepTime { get; set; }
        public string ArrDate { get; set; }
        public string ArrTime { get; set; }
        public string FlightClass { get; set; }
        public int FlightTime { get; set; }
        public double TotalAmount { get; set; }
        public double TaxAmount { get; set; }
        public int Stops { get; set; }
        public string ValCarrier { get; set; }
        public string FromTerminal { get; set; }
        public string ToTerminal { get; set; }
        public string MainClass { get; set; }
        public string FareBasis { get; set; }
        public double AgencyCharge { get; set; }
        public string FareType { get; set; }
        public int AvailSeats { get; set; }
        public string FlightRemarks { get; set; }
        public string TrackNo { get; set; }
        public string HoldAllowed { get; set; }
        public double HoldCharges { get; set; }
        public string HoldDuration { get; set; }
    }
}