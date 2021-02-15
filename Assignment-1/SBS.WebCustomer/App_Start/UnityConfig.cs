using SBS.BAL;
using SBS.BAL.Helper;
using SBS.BAL.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace SBS.WebCustomer
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICustomerManager, CustomerManager>();
            container.AddNewExtension<UnityRepositoryHelper>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}