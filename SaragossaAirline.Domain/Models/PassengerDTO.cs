using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaragossaAirline.Domain.Models {
    public class PassengerDTO {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsRetired { get; set; }
    }
}
