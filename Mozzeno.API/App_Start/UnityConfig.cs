using Mozzeno.Contracts.Data;
using Mozzeno.Contracts.Products;
using Mozzeno.Data.Repositories;
using Mozzeno.Services.Products;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace Mozzeno.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<ILoanPurposeRepository, LoanPurposeRepository>();

            container.RegisterType<IProductService, ProductService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}