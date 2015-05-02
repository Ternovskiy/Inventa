using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using InventaDataModul;
using Ninject;
using NUnit.Framework;

namespace webInventa.Test
{
    [SetUpFixture]
    public class UnitTestSetupFixture
    {
        protected static string Sandbox = "../../Sandbox";

        [SetUp]
        public virtual void Setup()
        {
            Console.WriteLine("===============");
            Console.WriteLine("=====START=====");
            Console.WriteLine("===============");
            //InitKernel();
        }

        [TearDown]
        public virtual void TearDown()
        {
            Console.WriteLine("===============");
            Console.WriteLine("=====BYE!======");
            Console.WriteLine("===============");
        }
        protected virtual IKernel InitKernel()
        {
            var kernel = new StandardKernel();
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
            //kernel.Bind<IMapper>().To<CommonMapper>();

//            //IConfig
//            InitConfig(kernel);
//            //Authentication
//            InitAuth(kernel);

            //IRepository
//            InitRepository(kernel);
//
//            kernel.Bind<MockMailSender>().To<MockMailSender>();
//            kernel.Bind<IMailSender>().ToMethod(p => kernel.Get<MockMailSender>().Object);

            //kernel.Bind<DataClassesInventaDataContext>().ToMethod(c => new DataClassesInventaDataContext());
            kernel.Bind<DataClassesInventaDataContext>().To<DataClassesInventaDataContext>();
            kernel.Bind<IRepository>().To<Repository>();

            return kernel;
        }

//        protected virtual void InitRepository(StandardKernel kernel)
//        {
//            kernel.Bind<MockRepository>().To<MockRepository>().InThreadScope();
//            kernel.Bind<IRepository>().ToMethod(p => kernel.Get<MockRepository>().Object);
//        }

//        protected virtual void InitConfig(StandardKernel kernel)
//        {
//            var fullPath = new FileInfo(Sandbox + "/Web.config").FullName;
//            kernel.Bind<IConfig>().ToMethod(c => new TestConfig(fullPath));
//        }

//        protected virtual void InitAuth(StandardKernel kernel)
//        {
//            kernel.Bind<HttpCookieCollection>().To<HttpCookieCollection>();
//            kernel.Bind<IAuthCookieProvider>().To<FakeAuthCookieProvider>().InSingletonScope();
//            kernel.Bind<IAuthentication>().ToMethod<CustomAuthentication>(c =>
//            {
//                var auth = new CustomAuthentication();
//                auth.AuthCookieProvider = kernel.Get<IAuthCookieProvider>();
//                return auth;
//            });
//        }


    }
}
