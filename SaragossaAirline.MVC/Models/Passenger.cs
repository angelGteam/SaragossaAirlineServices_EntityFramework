using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaragossaAirline.MVC.Models {
    public class Passenger {
        public int Id { get; set; }
        [DataType(DataType.Text), StringLength(12, MinimumLength = 10, ErrorMessage = "The DNI must have 10 to 12 characters")]
        public string DNI { get; set; }

        [DataType(DataType.Text), StringLength(100, MinimumLength = 2, ErrorMessage = "The name must have 10 to 12 characters")]
        public string FullName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        public bool IsRetired { get; set; }
    }
}
