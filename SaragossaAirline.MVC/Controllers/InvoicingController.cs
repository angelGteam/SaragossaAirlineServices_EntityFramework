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
        IInvoicingService invoicingService;
        
        public InvoicingController() {
            invoicingService = new InvoicingService();
        }

        public ActionResult InvoicingControl() {
            List<InvoicingDTO> invoicingsDTO = invoicingService.GetInvoicing();
            List<Invoicing> invoicings = Mapper.Map<List<Invoicing>>(invoicingsDTO);
            return View(invoicings);
        }
    }
}