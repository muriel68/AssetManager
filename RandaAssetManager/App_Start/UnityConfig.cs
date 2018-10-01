using System.Web.Mvc;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using Service.Interfaces;
using Service.Services;
using Unity;
using Unity.Mvc5;

namespace RandaAssetManager.App_Start
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
            container.RegisterType<IAssetService, AssetService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}