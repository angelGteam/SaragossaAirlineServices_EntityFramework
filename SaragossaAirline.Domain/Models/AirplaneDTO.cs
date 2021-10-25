using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaragossaAirline.Domain.Models {
    public class AirplaneDTO {
        public int Id { get; set; }
        public string Registration { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public int Review { get; set; }
        public int Airline { get; set; }
    }
}