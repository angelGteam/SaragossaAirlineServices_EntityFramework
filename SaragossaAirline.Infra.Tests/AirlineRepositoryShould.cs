using Moq;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
namespace SaragossaAirline.Infra.Tests {
    public class AirlineRepositoryShould {
        private readonly AirlineRepository airlineRepository;
        private readonly List<AirlineDTO> listOfAirlineDTOs;
        private readonly AirlineDTO airlineDTO;

        public AirlineRepositoryShould() {
            listOfAirlineDTOs = new List<AirlineDTO>();
            airlineDTO = new AirlineDTO { Id = 9, AverageAnnualTurnover = 59687.00m, CreationYear = 1977, Name = "A Sollicitudin Ltd" };
            listOfAirlineDTOs.Add(airlineDTO);
            airlineRepository = new AirlineRepository();
        }

        [Fact]
        public void Get_AllAirline_Returns_NotNull_List_Of_AirLineDTOs() {
            List<AirlineDTO> listOfAirlineFromBBDD = airlineRepository.GetAllAirline();
            listOfAirlineDTOs.Should().BeEquivalentTo(listOfAirlineFromBBDD);
        }
    }
}
