using MosApiTest3.IService;
using MosApiTest3.Models;
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
    [RoutePrefix("ApiTest")]
    public class StudentApiTestController : ApiController
    {
        private readonly IHttpClientStringHelper httpClientStringHelper;

        public StudentApiTestController(IHttpClientStringHelper httpClientStringHelper)
        {
            this.httpClientStringHelper = httpClientStringHelper;
        }
        
        [Route("GetAll")]
        public async Task<IHttpActionResult> GetAll()
        {
            try
            {
                var result = await httpClientStringHelper.Get<ResponseType>("api/Student");
                
                return Ok(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }

        [Route("Post")]
        public async Task<IHttpActionResult> Post(Student student)
        {
            try
            {
                var result = await httpClientStringHelper.Post<ResponseType, Student>("api/Student", student);

                return Ok(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }

        [Route("Put")]
        public async Task<IHttpActionResult> Put(Student student)
        {
            try
            {
                var result = await httpClientStringHelper.Put<ResponseType, Student>("api/Student", student);

                return Ok(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }

        [Route("Delete")]
        public async Task<IHttpActionResult> Delete(long id)
        {
            try
            {
                var result = await httpClientStringHelper.Delete<ResponseType>("api/Student/", id);

                return Ok(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }
    }
}
