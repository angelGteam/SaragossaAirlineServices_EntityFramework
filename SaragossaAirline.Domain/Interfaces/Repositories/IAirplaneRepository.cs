using SaragossaAirline.Domain.Models;
using System.Collections.Generic;

namespace SaragossaAirline.Domain.Interfaces.Repositories {
    public interface IAirplaneRepository {
        IEnumerable<AirplaneDTO> GetAllAirplane();
    }
}
