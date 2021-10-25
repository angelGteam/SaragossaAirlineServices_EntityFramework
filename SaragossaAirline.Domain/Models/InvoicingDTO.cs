using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaragossaAirline.Domain.Models {
    public class InvoicingDTO {
        public int Id { get; set; }
        public string AirplaneRegistration { get; set; }
        public string PassengerDNI { get; set; }
        public DateTime FlightDate { get; set; }
        public decimal Cost { get; set; }
    }
}