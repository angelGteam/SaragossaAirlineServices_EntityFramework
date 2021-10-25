using AutoMapper;
using SaragossaAirline.Domain.Interfaces.Services;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.MVC.Models;
using SaragossaAirline.ServiceLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaragossaAirline.MVC.Controllers {
    public class AirlineController : Controller {
        IAirlineService airlineService;
        
        public AirlineController() {
            airlineService = new AirlineService();
        }

        public ActionResult AirlineControl() {
            List<Airline> airlines = Mapper.Map<List<Airline>>(airlineService.GetAirline());
            return View(airlines);
        }
    }
}