using SaragossaAirline.MVC.Models;
using SaragossaAirline.ServiceLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Domain.Interfaces.Services;

namespace SaragossaAirline.MVC.Controllers {
    public class InvoicingController : Controller {
        IInvoicingService _invoicingService;
        
        public InvoicingController(IInvoicingService invoicingService) {
            _invoicingService = invoicingService;
        }

        public ActionResult InvoicingControl() {
            List<Invoicing> invoicings = Mapper.Map<List<Invoicing>>(_invoicingService.GetInvoicing());
            return View(invoicings);
        }
    }
}