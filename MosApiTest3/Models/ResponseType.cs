using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MosApiTest3.Models
{
    public class ResponseType
    {
        public bool success { get; set; }

        public string errorMessage { get; set; }

        public IEnumerable<Student> dataList { get; set; }

        public Student data { get; set; }
    }
}