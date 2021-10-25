using SaragossaAirline.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace SaragossaAirline.Infra.Context.Mappers {
    public class AirplaneMapper : EntityTypeConfiguration<AirplaneDTO> {
        public AirplaneMapper() {
            HasKey(i => i.Id);
            ToTable("airplane");
        }
    }
}
