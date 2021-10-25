using AutoMapper;
using SaragossaAirline.MVC.App_Start;
using SaragossaAirline.MVC.AutoMapperConfig;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SaragossaAirline.MVC {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapper.Mapper.Initialize(config:cfg => cfg.AddProfile<AutoMapperProfile>());
        }
    }
}
