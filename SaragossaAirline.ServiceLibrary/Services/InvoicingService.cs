using SaragossaAirline.Domain.Interfaces.Services;
using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Repositories;
using System.Collections.Generic;

namespace SaragossaAirline.ServiceLibrary.Services {
    public class InvoicingService : IInvoicingService {
        readonly InvoicingRepository invoicingRepository = new InvoicingRepository(System.Envoltorio.DatabaseType.ZaragozaAirline);
        public List<InvoicingDTO> GetInvoicing() => invoicingRepository.GetAllInvoicing();
    }
}
