using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaragossaAirline.MVC.Models {
    public class Airline {

        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required"), StringLength(100, MinimumLength = 3, ErrorMessage = "The name must have 3 to 100 characters")]
        public string Name { get; set; }
        [Range(1877, int.MaxValue)]
        public int CreationYear { get; set; }

        [Range(100.0, 100000.0, ErrorMessage = "It must be between 100 to 100000 eur")]
        public decimal AverageAnnualTurnover { get; set; }
    }
}