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
    public class AirplaneController : Controller {
        IAirplaneService airplaneService;

        public AirplaneController() {
            airplaneService = new AirplaneService();
        }
        
        public ActionResult AirplaneControl() {
            List<Airplane> airplanes = Mapper.Map<List<Airplane>>(airplaneService.GetAirplane());
            return View(airplanes);
        }
    }
}