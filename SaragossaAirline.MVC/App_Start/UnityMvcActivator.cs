using System.Linq;
using System.Web.Mvc;

using Unity.AspNet.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SaragossaAirline.MVC.UnityMvcActivator), nameof(SaragossaAirline.MVC.UnityMvcActivator.Start))]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(SaragossaAirline.MVC.UnityMvcActivator), nameof(SaragossaAirline.MVC.UnityMvcActivator.Shutdown))]

namespace SaragossaAirline.MVC {
    public static class UnityMvcActivator {
        public static void Start() {
            FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
            FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(UnityConfig.Container));
            DependencyResolver.SetResolver(new UnityDependencyResolver(UnityConfig.Container));
        }
        public static void Shutdown() {
            UnityConfig.Container.Dispose();
        }
    }
}