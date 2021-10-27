using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Models;
using System.Collections.Generic;
using SaragossaAirline.Infra.Context;
using System.Data.Entity;
using System.Linq;
using System;

namespace SaragossaAirline.Infra.Repositories {
    public class AirlineRepository : IAirlineRepository {
        private readonly ZaragozaAirlinesContext _airlinesContext;
        private readonly DbSet<AirlineDTO> _airlines;
        private readonly DbSet<AirplaneDTO> _airplanes;

        public AirlineRepository() {
            _airlinesContext = new ZaragozaAirlinesContext();
            _airlines = _airlinesContext.Set<AirlineDTO>();
            _airplanes = _airlinesContext.Set<AirplaneDTO>();
        }

        public Tuple<AirplaneDTO, string> GetAirplaneAndAirlineById(int airplaneID) {
            var query = (from airline in _airlines
                         join airplane in _airplanes on airline.Id equals airplane.Airline
                         where airplane.Id == airplaneID
                         select new {
                             AirlineName = airline.Name,
                             AirplaneId = airplane.Id,
                             AirplaneRegistration = airplane.Registration,
                             AirplaneBrand = airplane.Brand,
                             AirplaneModel = airplane.Model,
                             AirplaneProductionYear = airplane.ProductionYear,
                             AirplaneReview = airplane.Review,
                             AirplaneAirline = airplane.Airline,
                         }).Single();

            AirplaneDTO airplaneDTO = new AirplaneDTO {
                Id = query.AirplaneId,
                Registration = query.AirplaneRegistration,
                Brand = query.AirplaneBrand,
                Model = query.AirplaneModel,
                ProductionYear = query.AirplaneProductionYear,
                Review = query.AirplaneReview,
                Airline = query.AirplaneAirline
            };

            return new Tuple<AirplaneDTO, string>(airplaneDTO, query.AirlineName);
        }

        public IEnumerable<AirlineDTO> GetAllAirline() {
            return _airlines;
        }
    }
}
