using SaragossaAirline.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace SaragossaAirline.Infra.Context.Mappers {
    public class PassengerMapper : EntityTypeConfiguration<PassengerDTO> {
        public PassengerMapper() {
            HasKey(i => i.Id);
            ToTable("passenger");
        }
    }
}
