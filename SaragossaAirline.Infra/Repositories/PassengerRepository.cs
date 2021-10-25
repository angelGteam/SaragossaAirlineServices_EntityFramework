using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Helpers;
using SaragossaAirline.Infra.Queries;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Envoltorio;

namespace SaragossaAirline.Infra.Repositories {
    public class PassengerRepository : IPassengerRepository {
        private readonly string connectionString;
        public PassengerRepository(Database dBName) {
            connectionString = Getconnectionstring(dBName);
        }
        public List<PassengerDTO> GetAllPassenger() {
            List<PassengerDTO> passengers = new List<PassengerDTO>();
            using(var conn = new SqlConnection(connectionString)) {
                conn.Open();
                using(var command = new SqlCommand(QueriesConstants.SelectAllFromPassenger, conn)) {
                    var dataReader = command.ExecuteReader();
                    while(dataReader.Read()) {
                        PassengerDTO passenger = QueriesHelper.GetPassenger(dataReader);
                        passengers.Add(passenger);
                    }
                }
            }
            return passengers;
        }
    }
}
