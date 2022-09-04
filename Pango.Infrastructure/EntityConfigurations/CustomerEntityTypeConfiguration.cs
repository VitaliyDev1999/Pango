using Microsoft.EntityFrameworkCore;
using Pango.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pango.Infrastructure.EntityConfigurations;

public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder
            .ToTable("Customer")
            .HasKey(u => u.Id);
    }
}
