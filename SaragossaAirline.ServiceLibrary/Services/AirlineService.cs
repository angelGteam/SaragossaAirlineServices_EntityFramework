using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Interfaces.Services;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System.Collections.Generic;

namespace SaragossaAirline.ServiceLibrary.Services {
    public class AirlineService : IAirlineService{
        readonly IAirlineRepository airlineRepository = new AirlineRepository(System.Envoltorio.Database.ZaragozaAirline);
        public List<AirlineDTO> GetAirline() => airlineRepository.GetAllAirline();
    }
}
