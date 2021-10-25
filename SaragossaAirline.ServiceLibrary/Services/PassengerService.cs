using SaragossaAirline.Domain.Interfaces.Services;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System.Collections.Generic;

namespace SaragossaAirline.ServiceLibrary.Services {
    public class PassengerService : IPassengerService {
        readonly PassengerRepository passengerRepository = new PassengerRepository(System.Envoltorio.Database.ZaragozaAirline);
        public List<PassengerDTO> GetPassenger() => passengerRepository.GetAllPassenger();
    }
}
