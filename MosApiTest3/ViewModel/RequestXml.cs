using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MosApiTest3.ViewModel
{
    public class TheSearchRequest
    {
        public RequestXml RequestXml { get; set; }
    }

    public class RequestXml
    {
        public Authenticate Authenticate { get; set; }

        public GetFlightAvailibilityRequest GetFlightAvailibilityRequest { get; set; }
    }
}