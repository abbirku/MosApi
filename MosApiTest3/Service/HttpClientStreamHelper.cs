using MosApiTest3.CustomException;
using MosApiTest3.IService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace MosApiTest3.Service
{
    public class HttpClientStreamHelper : IHttpClientStreamHelper
    {
        private readonly string baseUri;
        private readonly HttpClient client;

        public HttpClientStreamHelper()
        {
            baseUri = "http://stagingv2.flightmyweb.com";
            client = new HttpClient();
        }

        private void CommonSetup()
        {
            //Common settings
            client.BaseAddress = new Uri(baseUri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        private T DeserializeJsonFromStream<T>(Stream stream)
        {
            if (stream == null || stream.CanRead == false)
                return default(T);

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                var js = new JsonSerializer();
                var searchResult = js.Deserialize<T>(jtr);
                return searchResult;
            }
        }

        private async Task<string> StreamToStringAsync(Stream stream)
        {
            string content = null;

            if (stream != null)
                using (var sr = new StreamReader(stream))
                    content = await sr.ReadToEndAsync();

            return content;
        }

        private async Task<T> GetDeserializeObjectFromStream<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();

                if (response.IsSuccessStatusCode)
                    return DeserializeJsonFromStream<T>(stream);

                var content = await StreamToStringAsync(stream);
                throw new ApiException((int)response.StatusCode, content);
            }

            return default(T);
        }

        public async Task<T> StreamDelete<T>(string methodUri, long id)
        {
            //Common settings
            CommonSetup();

            //Get method
            HttpResponseMessage response = await client.DeleteAsync($"{methodUri}/{id}");
            var result = await GetDeserializeObjectFromStream<T>(response);
            return result;
        }

        public async Task<T> StreamGet<T>(string methodUri)
        {
            //Common settings
            CommonSetup();

            //Get method
            HttpResponseMessage response = await client.GetAsync(methodUri);
            var result = await GetDeserializeObjectFromStream<T>(response);
            return result;
        }

        public async Task<T> StreamPost<T, Ts>(string methodUri, Ts obj)
        {
            //Common settings
            CommonSetup();

            //Get method
            HttpResponseMessage response = await client.PostAsJsonAsync(methodUri, obj);
            var result = await GetDeserializeObjectFromStream<T>(response);
            return result;
        }

        public async Task<T> StreamPut<T, Ts>(string methodUri, Ts obj)
        {
            //Common settings
            CommonSetup();

            //Get method
            HttpResponseMessage response = await client.PutAsJsonAsync(methodUri, obj);
            var result = await GetDeserializeObjectFromStream<T>(response);
            return result;
        }
    }
}