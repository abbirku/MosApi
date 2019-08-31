using MosApiTest3.CustomException;
using MosApiTest3.IService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace MosApiTest3.Service
{
    public class HttpClientStringHelper : IHttpClientStringHelper
    {
        private readonly string baseUri;
        private readonly HttpClient client;

        public HttpClientStringHelper()
        {
            baseUri = "http://stagingv2.flightmyweb.com";
            client = new HttpClient();
        }
        
        private T GetDeserializeObjectFromString<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var responseResult = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<T>(responseResult);
            }

            return default(T);
        }
        
        private void CommonSetup()
        {
            //Common settings
            client.BaseAddress = new Uri(baseUri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> Get<T>(string methodUri)
        {
            //Common settings
            CommonSetup();

            //Get method
            HttpResponseMessage response = await client.GetAsync(methodUri);
            return GetDeserializeObjectFromString<T>(response);
        }
        
        public async Task<T> Post<T, Ts>(string methodUri, Ts obj)
        {
            //Common settings
            CommonSetup();

            //Get method
            HttpResponseMessage response = await client.PostAsJsonAsync(methodUri, obj);
            return GetDeserializeObjectFromString<T>(response);
        }
        
        public async Task<T> Put<T, Ts>(string methodUri, Ts obj)
        {
            //Common settings
            CommonSetup();

            //Get method
            HttpResponseMessage response = await client.PutAsJsonAsync(methodUri, obj);
            return GetDeserializeObjectFromString<T>(response);
        }

        public async Task<T> Delete<T>(string methodUri, long id)
        {
            //Common settings
            CommonSetup();

            //Get method
            HttpResponseMessage response = await client.DeleteAsync($"{methodUri}/{id}");
            return GetDeserializeObjectFromString<T>(response);
        }
    }
}