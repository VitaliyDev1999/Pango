//using Microsoft.EntityFrameworkCore;
//using Pango.Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace Pango.Infrastructure.EntityConfigurations;

//public class ParkingParkingZoneEntityTypeConfiguration : IEntityTypeConfiguration<ParkingParkingZone>
//{
//    public void Configure(EntityTypeBuilder<ParkingParkingZone> builder)
//    {
//        builder
//            .ToTable(" ParkingParkingZone")
//            .HasKey(u => u.Id);

//        builder.HasOne(ic => ic.ParkingZone)
//               .WithMany(i => i.ParkingParkingZone)
//               .HasForeignKey(ic => ic.ParkingZoneId)
//               .OnDelete(DeleteBehavior.Cascade);
//        builder.HasOne(ic => ic.ParkingRecord)
//            .WithMany(i => i.ParkingParkingZone)
//            .HasForeignKey(ic => ic.ParkingId)
//            .OnDelete(DeleteBehavior.Cascade);
//    }
//}

