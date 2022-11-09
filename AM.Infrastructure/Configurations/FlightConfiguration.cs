using AM.ApplicationCore.Domaine;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace AM.Infrastructure.Configurations
{
    internal class FlightConfiguration: IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(s => s.Passengers)
          .WithMany(c => c.Flights)
          .UsingEntity(
          j => j.ToTable("Reservation")
          ); //Table d'association;
            builder.HasOne(f => f.Plane)
                .WithMany(p => p.Flights)
                .HasForeignKey(f => f.PlaneId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
