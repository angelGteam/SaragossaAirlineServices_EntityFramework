using SaragossaAirline.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace SaragossaAirline.Infra.Context.Mappers {
    public class InvoicingMapper : EntityTypeConfiguration<InvoicingDTO> {
        public InvoicingMapper() {
            HasKey(i => i.Id);
            ToTable("invoicing");
        }
    }
}
