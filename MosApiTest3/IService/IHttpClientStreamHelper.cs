using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosApiTest3.IService
{
    public interface IHttpClientStreamHelper
    {
        Task<T> StreamGet<T>(string methodUri);
        Task<T> StreamPost<T, Ts>(string methodUri, Ts obj);
        Task<T> StreamPut<T, Ts>(string methodUri, Ts obj);
        Task<T> StreamDelete<T>(string methodUri, long id);
    }
}
