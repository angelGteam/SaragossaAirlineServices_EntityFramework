using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Context;
using SaragossaAirline.Infra.Helpers;
using SaragossaAirline.Infra.Queries;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using static System.Envoltorio;

namespace SaragossaAirline.Infra.Repositories {
    public class PassengerRepository : IPassengerRepository {
        private readonly ZaragozaAirlinesContext _airlinesContext;
        private readonly DbSet<PassengerDTO> _passengers;
        public PassengerRepository() {
            _airlinesContext = new ZaragozaAirlinesContext();
            _passengers = _airlinesContext.Set<PassengerDTO>();
        }
        public IEnumerable<PassengerDTO> GetAllPassenger() {
            return _passengers;
        }
    }
}
