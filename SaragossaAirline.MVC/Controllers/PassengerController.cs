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
        IPassengerService _passengerService;

        public PassengerController(IPassengerService passengerService) {
            _passengerService = passengerService;
        }

        public ActionResult PassengerControl() {
            List<Passenger> passengers = Mapper.Map<List<Passenger>>(_passengerService.GetPassenger());
            return View(passengers);
        }
    }
}