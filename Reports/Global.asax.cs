using Ninject;
using Ninject.Web.Mvc;
using Reports.Context;
using Reports.IServises;
using Reports.Repositories;
using Reports.Repositories.IRepositories;
using Reports.Servises;
using Reports.Servises.IServises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Reports
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfigureServise();
        }
        private void ConfigureServise()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<DbReports>().To<DbReports>();
            ninjectKernel.Bind<IShippingRepository>().To<ShippingRepository>();
            ninjectKernel.Bind<IUserRepository>().To<UserRepository>();
            ninjectKernel.Bind<IUserServise>().To<UserServise>();
            ninjectKernel.Bind<IShippingServise>().To<ShippingServise>();
            DependencyResolver.SetResolver(new NinjectDependencyResolver(ninjectKernel));
        }
    }
}
