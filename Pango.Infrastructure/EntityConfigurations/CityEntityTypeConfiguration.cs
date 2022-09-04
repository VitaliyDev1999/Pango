using Microsoft.EntityFrameworkCore;
using Pango.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pango.Infrastructure.EntityConfigurations;

public class CityEntityTypeConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder
            .ToTable("City")
            .HasKey(u => u.Id);
    }
}