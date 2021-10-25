using SaragossaAirline.Domain.Interfaces.Services;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System.Collections.Generic;

namespace SaragossaAirline.ServiceLibrary.Services {
    public class AirplaneService : IAirplaneService {
        readonly AirplaneRepository airplaneRepository = new AirplaneRepository(System.Envoltorio.DatabaseType.ZaragozaAirline);
        public List<AirplaneDTO> GetAirplane() => airplaneRepository.GetAllAirplane();
    }
}
