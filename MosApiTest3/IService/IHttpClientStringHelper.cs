using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosApiTest3.IService
{
    public interface IHttpClientStringHelper
    {
        Task<T> Get<T>(string methodUri);
        Task<T> Post<T, Ts>(string methodUri, Ts obj);
        Task<T> Put<T, Ts>(string methodUri, Ts obj);
        Task<T> Delete<T>(string methodUri, long id);
    }
}
