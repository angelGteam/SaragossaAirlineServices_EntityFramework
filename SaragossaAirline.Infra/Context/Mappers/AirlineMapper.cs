using SaragossaAirline.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace SaragossaAirline.Infra.Context.Mappers {
    public class AirlineMapper : EntityTypeConfiguration<AirlineDTO> {
        public AirlineMapper() {
            HasKey(i => i.Id);
            Property(m => m.AverageAnnualTurnover).HasColumnName("avganualinvoicing");
            ToTable("airline");
        }
    }
}
