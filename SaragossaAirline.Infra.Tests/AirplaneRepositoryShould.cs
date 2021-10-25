using Moq;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
namespace SaragossaAirline.Infra.Tests {
    public class AirplaneRepositoryShould {
        readonly AirplaneRepository airplaneRepository;
        readonly List<AirplaneDTO> listOfAirplanes;
        readonly AirplaneDTO airplaneDTO;
        public AirplaneRepositoryShould() {
            listOfAirplanes = new List<AirplaneDTO>();
            airplaneDTO = new AirplaneDTO { Airline = 9, Brand = "Boeing", Id = 2, Registration = "4292 DWG", Model = "747", ProductionYear = 1999, Review = 25 };
            listOfAirplanes.Add(airplaneDTO);
            airplaneRepository = new AirplaneRepository(Envoltorio.Database.ZaragozaAirline_Test);
        }

        [Fact]
        public void Get_AllAirline_Returns_NotNull_List_Of_AirLineDTOs() {
            List<AirplaneDTO> listOfAirlineFromBBDD = airplaneRepository.GetAllAirplane();
            listOfAirplanes.Should().BeEquivalentTo(listOfAirlineFromBBDD);
        }
    }
}
