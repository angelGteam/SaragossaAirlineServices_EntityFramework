﻿using SaragossaAirline.Domain.Models;
using System.Collections.Generic;

namespace SaragossaAirline.Domain.Interfaces.Services {
    public interface IAirplaneService {
        List<AirplaneDTO> GetAirplane();
    }
}
