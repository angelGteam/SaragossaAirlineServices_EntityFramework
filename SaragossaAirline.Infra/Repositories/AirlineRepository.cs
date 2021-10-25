using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Models;
using System.Collections.Generic;
using SaragossaAirline.Infra.Context;
using System.Data.Entity;
using System.Linq;

namespace SaragossaAirline.Infra.Repositories {
    public class AirlineRepository : IAirlineRepository {
        private readonly ZaragozaAirlinesContext _airlinesContext;
        private readonly DbSet<AirlineDTO> _airlines;

        public AirlineRepository() {
            _airlinesContext = new ZaragozaAirlinesContext();
            _airlines = _airlinesContext.Set<AirlineDTO>();
        }

        public List<AirlineDTO> GetAllAirline() {
            return (List<AirlineDTO>)_airlines.ToList();
        }
    }
}
