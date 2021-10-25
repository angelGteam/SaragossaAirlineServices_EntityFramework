using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Helpers;
using SaragossaAirline.Infra.Queries;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Envoltorio;

namespace SaragossaAirline.Infra.Repositories {
    public class InvoicingRepository : IInvoicingRepository{
        private readonly string connectionString;

        public InvoicingRepository(Database dBName) {
            connectionString = Getconnectionstring(dBName);
        }

        public List<InvoicingDTO> GetAllInvoicing() {
            List<InvoicingDTO> invoicings = new List<InvoicingDTO>();
            using(var conn = new SqlConnection(connectionString)) {
                conn.Open();
                using(var command = new SqlCommand(QueriesConstants.SelectAllFromInvoicing, conn)) {
                    var dataReader = command.ExecuteReader();
                    while(dataReader.Read()) {
                        InvoicingDTO invoicing = QueriesHelper.GetInvoicing(dataReader);
                        invoicings.Add(invoicing);
                    }
                }
            }
            return invoicings;
        }
    }
}
