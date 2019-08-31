using MosApiTest3.IService;
using MosApiTest3.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace MosApiTest3.Controllers
{
    [RoutePrefix("API")]
    public class MosApiController : ApiController
    {
        private readonly IHttpClientStreamHelper httpClientStreamHelper;
        private readonly IHttpClientStringHelper httpClientStringHelper;

        public MosApiController(IHttpClientStreamHelper httpClientStreamHelper, IHttpClientStringHelper httpClientStringHelper)
        {
            this.httpClientStreamHelper = httpClientStreamHelper;
            this.httpClientStringHelper = httpClientStringHelper;
        }

        [Route("FlightAvailibility")]
        public async Task<IHttpActionResult> FlightAvailibility(TheSearchRequest request)
        {
            try
            {
                //var result = await httpClientStringHelper.PostAndGetByStream<FlightAvailibilityResponse, TheSearchRequest>("API/FlightAvailibility", request);
                var result = await httpClientStreamHelper.StreamPost<FlightAvailibilityResponse, TheSearchRequest>("API/FlightAvailibility", request);
                
                return Ok(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }
    }
}
