using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domaine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder
            .HasKey(sc => new { sc.NumTicket, sc.PassengerFK ,sc.FlightFK});

            builder
            .HasOne(sc => sc.passenger)
            .WithMany(b => b.Tickets)
            .HasForeignKey(sc => sc.PassengerFK);

            builder
            .HasOne(sc => sc.flight)
            .WithMany(c => c.Tickets)
            .HasForeignKey(sc => sc.FlightFK);
        }

       
    }
}
