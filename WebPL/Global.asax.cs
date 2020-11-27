using Ninject;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject.Web.Common.WebHost;
using Gym.BLL.Interfaces;
using Gym.BLL;
using Gym.DAL.Interfaces;
using Gym.DAL;
namespace WebPL
{
    public class MvcApplication : NinjectHttpApplication
    {
        public override void Init()
        {
            base.Init();
        }
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            Registration(kernel);
            return kernel;
        }
        private void Registration(IKernel kernel)
        {
            
            kernel.Bind<IClientLogic>().To<ClientLogic>().InSingletonScope();
            kernel.Bind<ICoachLogic>().To<CoachLogic>().InSingletonScope();
            kernel.Bind<IHallLogic>().To<HallLogic>().InSingletonScope();
            kernel.Bind<IGroupLogic>().To<GroupLogic>().InSingletonScope();
            kernel.Bind<IKindOfSportLogic>().To<KindOfSportLogic>().InSingletonScope();
            kernel.Bind<IUserLogic>().To<UserLogic>().InSingletonScope();

            kernel.Bind<IClientDao>().To<ClientDaoDB>().InSingletonScope();
            kernel.Bind<ICoachDao>().To<CoachDaoDB>().InSingletonScope();
            kernel.Bind<IHallDao>().To<HallDaoDB>().InSingletonScope();
            kernel.Bind<IGroupDao>().To<GroupDaoDB>().InSingletonScope();
            kernel.Bind<IKindOfSportDao>().To<KindOfSportDaoDB>().InSingletonScope();
            kernel.Bind<IUserDao>().To<UserDaoDB>().InSingletonScope();
            
        }
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
