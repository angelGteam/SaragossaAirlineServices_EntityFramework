using SaragossaAirline.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaragossaAirline.Infra.Helpers {
    internal class QueriesHelper {
        internal static AirlineDTO GetAirline(SqlDataReader dataReader) {
            var ret = new AirlineDTO {
                Id = Convert.ToInt32(dataReader["id"]),
                Name = dataReader["name"].ToString(),
                AverageAnnualTurnover = Convert.ToDecimal(dataReader["avganualinvoicing"]),
                CreationYear = Convert.ToInt32(dataReader["creationyear"]),
            };
            return ret;
        }
        internal static AirplaneDTO GetAirplane(SqlDataReader dataReader) {
            var ret = new AirplaneDTO {
                Id = Convert.ToInt32(dataReader["Id"]),
                Registration = dataReader["registration"].ToString(),
                Brand = dataReader["brand"].ToString(),
                Model = dataReader["model"].ToString(),
                ProductionYear = Convert.ToInt32(dataReader["productionyear"]),
                Review = Convert.ToInt32(dataReader["review"]),
                Airline = Convert.ToInt32(dataReader["airline"]),
            };
            return ret;
        }
        internal static PassengerDTO GetPassenger(SqlDataReader dataReader) {
            var ret = new PassengerDTO {
                Id = Convert.ToInt32(dataReader["id"]),
                DNI = dataReader["dni"].ToString(),
                FullName = dataReader["fullname"].ToString(),
                BirthDate = Convert.ToDateTime(dataReader["birthdate"]),
                IsRetired = Convert.ToBoolean(dataReader["isRetired"]),
            };
            return ret;
        }
        internal static InvoicingDTO GetInvoicing(SqlDataReader dataReader) {
            var ret = new InvoicingDTO {
                Id = Convert.ToInt32(dataReader["id"]),
                AirplaneRegistration = dataReader["airplaneregistration"].ToString(),
                PassengerDNI = dataReader["passengerdni"].ToString(),
                FlightDate = Convert.ToDateTime(dataReader["flightdate"]),
                Cost = Convert.ToDecimal(dataReader["cost"]
                ),
            };
            return ret;
        }
    }
}
