using System.Web.Mvc;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using Unity;
using Unity.Mvc5;

namespace DAL
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<IRandaDBContext, RandaDBContext>();
            container.RegisterType<IAssetRepository, AssetRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}