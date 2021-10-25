using SaragossaAirline.Domain.Models;
using System.Collections.Generic;

namespace SaragossaAirline.Domain.Interfaces.Repositories {
    public interface IAirlineRepository {
        IEnumerable<AirlineDTO> GetAllAirline();
    }
}
