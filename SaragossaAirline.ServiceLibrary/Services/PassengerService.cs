using SaragossaAirline.Domain.Interfaces.Services;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System.Collections.Generic;

namespace SaragossaAirline.ServiceLibrary.Services {
    public class PassengerService : IPassengerService {
        readonly PassengerRepository passengerRepository = new PassengerRepository();
        public IEnumerable<PassengerDTO> GetPassenger() => passengerRepository.GetAllPassenger();
    }
}
