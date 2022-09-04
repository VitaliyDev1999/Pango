using Microsoft.EntityFrameworkCore;
using Pango.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pango.Infrastructure.EntityConfigurations;

public class ParkingZoneEntityTypeConfiguration : IEntityTypeConfiguration<ParkingZone>
{
    public void Configure(EntityTypeBuilder<ParkingZone> builder)
    {
        builder
            .ToTable("ParkingZone")
            .HasKey(u => u.Id);
    }
}
