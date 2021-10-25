using SaragossaAirline.Domain.Models;
using SaragossaAirline.Infra.Context.Mappers;
using System.Data.Entity;
using static System.Envoltorio;
using Database = System.Envoltorio.DatabaseType;

namespace SaragossaAirline.Infra.Context {
    public class ZaragozaAirlinesContext : DbContext {
        public ZaragozaAirlinesContext() : base(Getconnectionstring(DatabaseType.ZaragozaAirline)) {
        }
        public DbSet<AirlineDTO> Airlines { get; set; }
        public DbSet<AirplaneDTO> Airplanes { get; set; }
        public DbSet<InvoicingDTO> Invoicings { get; set; }
        public DbSet<PassengerDTO> Passengers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new AirplaneMapper());
            modelBuilder.Configurations.Add(new AirlineMapper());
            modelBuilder.Configurations.Add(new InvoicingMapper());
            modelBuilder.Configurations.Add(new PassengerMapper());

            base.OnModelCreating(modelBuilder);
        }
    }
}