using FluentAssertions;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SaragossaAirline.Infra.Tests {
    public class PassengerRepositoryShould {
        private readonly PassengerRepository passengerRepository;
        private readonly List<PassengerDTO> listOfPassengers;
        private readonly PassengerDTO passengerDTO;

        public PassengerRepositoryShould() {
            listOfPassengers = new List<PassengerDTO>();
            passengerDTO = new PassengerDTO { Id = 1, BirthDate = new DateTime(1994, 07, 03, 00, 00, 00), DNI = "55173155L", FullName = "LORENZO GOMEZ MORENO", IsRetired = false };
            listOfPassengers.Add(passengerDTO);
            passengerRepository = new PassengerRepository(Envoltorio.DatabaseType.ZaragozaAirline_Test);
        }
        [Fact]
        public void Get_AllAirline_Returns_NotNull_List_Of_AirLineDTOs() {
            List<PassengerDTO> listOfPassengersFromBBDD = passengerRepository.GetAllPassenger();
            listOfPassengers.Should().BeEquivalentTo(listOfPassengersFromBBDD);
        }
    }
}
