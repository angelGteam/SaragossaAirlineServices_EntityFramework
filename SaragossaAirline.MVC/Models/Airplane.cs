using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaragossaAirline.MVC.Models {
    public class Airplane {
        [Range(0, 100)]
        public int Id { get; set; }
        [DataType(DataType.Text), StringLength(10, ErrorMessage = "Registration cannot have more than 10 characters")]
        public string Registration { get; set; }

        [DataType(DataType.Text), StringLength(100, MinimumLength = 3, ErrorMessage = "Brand must be between 3 and 100 characters")]
        public string Brand { get; set; }

        [DataType(DataType.Text), StringLength(100, MinimumLength = 3, ErrorMessage = "Model must be between 3 and 100 characters")]
        public string Model { get; set; }

        [Range(1877, int.MaxValue)]
        public int ProductionYear { get; set; }

        [Range(0, 100, ErrorMessage = "Review must be between 1 and 100")]
        public int Review { get; set; }

        [Range(0, int.MaxValue)]
        public int Airline { get; set; }
    }
}