using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SaragossaAirline.Infra.Repositories {
    public class AirplaneRepository : IAirplaneRepository {
        private readonly ZaragozaAirlinesContext _airlinesContext;
        private readonly DbSet<AirplaneDTO> _airplanes;

        public AirplaneRepository() {
            _airlinesContext = new ZaragozaAirlinesContext();
            _airplanes = _airlinesContext.Set<AirplaneDTO>();
        }

        public IEnumerable<AirplaneDTO> GetAllAirplane() {
            return _airplanes;
        }
    }
}
