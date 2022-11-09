using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domaine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    internal class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasDiscriminator<String>("IsTraveller")
                    .HasValue<Traveller>("1")
                    .HasValue<Staff>("2")
                    .HasValue<Passenger>("0");
            builder.OwnsOne(c => c.Fullname,
                                fn => {
                            fn.Property(a => a.FirstName).HasMaxLength(30)
                                    .HasColumnName("PassFirstName");
                                    fn.Property(a => a.LastName).IsRequired()
                                    .HasColumnName("PassLastName");

                                });
        }
    }
}
