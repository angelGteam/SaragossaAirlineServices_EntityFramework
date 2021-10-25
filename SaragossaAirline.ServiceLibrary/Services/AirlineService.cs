using SaragossaAirline.Domain.Interfaces.Services;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System.Collections.Generic;

namespace SaragossaAirline.ServiceLibrary.Services {
    public class AirlineService : IAirlineService{
        readonly AirlineRepository airlineRepository = new AirlineRepository();
        public IEnumerable<AirlineDTO> GetAirline() => airlineRepository.GetAllAirline();
    }
}
