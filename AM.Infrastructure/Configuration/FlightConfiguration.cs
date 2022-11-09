using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(f => f.passengers).WithMany(c => c.flights)
                 .UsingEntity(i => i.ToTable("reservation"));

            builder.HasOne(f => f.Plane).WithMany(p => p.flights).HasForeignKey(p => p.PlaneId)
                .OnDelete(deleteBehavior: DeleteBehavior.ClientSetNull);
            
        }
    }
}
