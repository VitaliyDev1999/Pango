using Microsoft.EntityFrameworkCore;
using Pango.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Pango.Infrastructure.EntityConfigurations;

public class ParkingRecordEntityTypeConfiguration : IEntityTypeConfiguration<ParkingRecord>
{
    public void Configure(EntityTypeBuilder<ParkingRecord> builder)
    {
        builder
            .ToTable("Parking")
            .HasKey(u => u.Id);
    }
}
