using SaragossaAirline.Domain.Interfaces.Repositories;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Context;
using SaragossaAirline.Infra.Helpers;
using SaragossaAirline.Infra.Queries;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace SaragossaAirline.Infra.Repositories {
    public class InvoicingRepository : IInvoicingRepository{
        private readonly ZaragozaAirlinesContext _airlinesContext;
        private readonly DbSet<InvoicingDTO> _invoicings;

        public InvoicingRepository() {
            _airlinesContext = new ZaragozaAirlinesContext();
            _invoicings = _airlinesContext.Set<InvoicingDTO>();
        }

        public IEnumerable<InvoicingDTO> GetAllInvoicing() {
            return _invoicings;
        }
    }
}
