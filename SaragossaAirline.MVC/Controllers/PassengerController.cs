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
    public class PassengerController : Controller {
        IPassengerService passengerService;

        public PassengerController() {
            passengerService = new PassengerService();
        }

        public ActionResult PassengerControl() {
            List<Passenger> passengers = Mapper.Map<List<Passenger>>(passengerService.GetPassenger());
            return View(passengers);
        }
    }
}