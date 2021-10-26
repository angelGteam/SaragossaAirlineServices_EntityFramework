using SaragossaAirline.Domain.Interfaces.Services;
using SaragossaAirline.ServiceLibrary.Services;
using System;

using Unity;

namespace SaragossaAirline.MVC {
    public static class UnityConfig {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() => {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });
       
        public static IUnityContainer Container => container.Value;
        #endregion
        
        public static void RegisterTypes(IUnityContainer container) {
            container.RegisterType<IAirlineService, AirlineService>();
            container.RegisterType<IAirplaneService, AirplaneService>();
            container.RegisterType<IPassengerService, PassengerService>();
            container.RegisterType<IInvoicingService, InvoicingService>();
        }
    }
}