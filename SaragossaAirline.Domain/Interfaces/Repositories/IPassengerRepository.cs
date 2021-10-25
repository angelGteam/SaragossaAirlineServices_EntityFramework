using SaragossaAirline.Domain.Models;
using System.Collections.Generic;

namespace SaragossaAirline.Domain.Interfaces.Repositories {
    public interface IPassengerRepository {
        IEnumerable<PassengerDTO> GetAllPassenger(); 
    }
}
