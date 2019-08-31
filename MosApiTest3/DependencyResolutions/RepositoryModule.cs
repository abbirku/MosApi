using MosApiTest3.IRepository;
using MosApiTest3.IService;
using MosApiTest3.Models;
using MosApiTest3.Repository;
using MosApiTest3.Service;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MosApiTest3.DependencyResolutions
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DatabaseContext>().ToSelf().InSingletonScope();
            Bind<IStudentRepository>().To<StudentRepository>();
            Bind<IHttpClientStringHelper>().To<HttpClientStringHelper>();
            Bind<IHttpClientStreamHelper>().To<HttpClientStreamHelper>();
        }
    }
}