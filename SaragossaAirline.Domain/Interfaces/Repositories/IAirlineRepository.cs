using SaragossaAirline.Domain.Models;
using System.Collections.Generic;

namespace SaragossaAirline.Domain.Interfaces.Repositories {
    public interface IAirlineRepository {
        List<AirlineDTO> GetAllAirline();
    }
}
