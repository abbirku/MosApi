using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MosApiTest3.CustomException
{
    public class ApiException : Exception
    {
        public ApiException(int statusCode, string content)
            : base($"Status Code: {statusCode} Content: {content}")
        {
        }
    }
}