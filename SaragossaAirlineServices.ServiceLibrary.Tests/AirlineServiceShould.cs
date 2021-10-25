using Moq;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System;
using System.Collections.Generic;
using Xunit;

namespace SaragossaAirlineServices.ServiceLibrary.Tests {
    public class AirlineServiceShould {
        Mock<AirlineRepository> airlineRepositoryMock;
        private readonly List<AirlineDTO> airlines;
        public AirlineServiceShould() {
            airlines = new List<AirlineDTO>();
            airlineRepositoryMock = new Mock<AirlineRepository>();
            airlineRepositoryMock.Setup(x => x.GetAllAirline()).Returns(airlines);
        }

    }
}
