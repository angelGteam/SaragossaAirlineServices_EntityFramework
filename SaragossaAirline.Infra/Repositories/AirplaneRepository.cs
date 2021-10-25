using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Helpers;
using SaragossaAirline.Infra.Queries;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Envoltorio;

namespace SaragossaAirline.Infra.Repositories {
    public class AirplaneRepository : IAirplaneRepository {
        private readonly string connectionString;

        public AirplaneRepository(Database dBName) {
            connectionString = Getconnectionstring(dBName);
        }

        public List<AirplaneDTO> GetAllAirplane() {
            List<AirplaneDTO> airplanes = new List<AirplaneDTO>();
            using(var conn = new SqlConnection(connectionString)) {
                conn.Open();
                using(var command = new SqlCommand(QueriesConstants.SelectAllFromAirplane, conn)) {
                    var dataReader = command.ExecuteReader();
                    while(dataReader.Read()) {
                        AirplaneDTO airplane = QueriesHelper.GetAirplane(dataReader);
                        airplanes.Add(airplane);
                    }
                }
            }
            return airplanes;
        }
    }
}
