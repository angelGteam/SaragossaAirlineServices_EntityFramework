using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Helpers;
using SaragossaAirline.Infra.Queries;
using System.Collections.Generic;
using System.Configuration;
using System;
using System.Data.SqlClient;
using static System.Envoltorio;

namespace SaragossaAirline.Infra.Repositories {
    public class AirlineRepository : IAirlineRepository {
        private readonly string connectionString;
        
        public AirlineRepository(Database dBName) {
            connectionString = Getconnectionstring(dBName);
        }
        
        public List<AirlineDTO> GetAllAirline() {
            List<AirlineDTO> airlines = new List<AirlineDTO>();
            using(var conn = new SqlConnection(connectionString)) {
                conn.Open();
                using(var command = new SqlCommand(QueriesConstants.SelectAllfromAirline, conn)) {
                    var dataReader = command.ExecuteReader();
                    while(dataReader.Read()) {
                        AirlineDTO airline = QueriesHelper.GetAirline(dataReader);
                        airlines.Add(airline);
                    }
                }
            }
            return airlines;
        }
    }
}
