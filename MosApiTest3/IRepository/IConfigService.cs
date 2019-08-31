using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosApiTest3.IRepository
{
    public interface IConfigService
    {
        string ConnectionString { get; }
    }
}
