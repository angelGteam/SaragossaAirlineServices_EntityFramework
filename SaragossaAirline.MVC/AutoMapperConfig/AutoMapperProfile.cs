using AutoMapper;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaragossaAirline.MVC.AutoMapperConfig {
    public class AutoMapperProfile : Profile {
        public AutoMapperProfile() {
            CreateMap<AirplaneDTO, Airplane>();
            CreateMap<AirlineDTO, Airline>();
            CreateMap<InvoicingDTO, Invoicing>();
            CreateMap<PassengerDTO, Passenger>();
        }
    }
}