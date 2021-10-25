using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaragossaAirline.Domain.Models {
    public class AirlineDTO {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreationYear { get; set; }
        public decimal AverageAnnualTurnover { get; set; }
    }
}