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
        IAirplaneService _airplaneService;

        public AirplaneController(IAirplaneService airplaneService) {
            _airplaneService = airplaneService;
        }
        
        public ActionResult AirplaneControl() {
            List<Airplane> airplanes = Mapper.Map<List<Airplane>>(_airplaneService.GetAirplane());
            return View(airplanes);
        }
    }
}