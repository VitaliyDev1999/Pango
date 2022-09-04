using Microsoft.EntityFrameworkCore;
using Pango.Domain.Entities;
using Pango.Domain.Interfaces;

namespace Pango.Infrastructure;

public sealed class PangoContext : DbContext, IUnitOfWork
{
    public DbSet<Customer> Customer { get; set; }
    public DbSet<ParkingRecord> ParkingRecord { get; set; }
    public DbSet<ParkingZone> ParkingZone { get; set; }

    public DbSet<City> City { get; set; }

    public PangoContext(DbContextOptions options) : base(options) { }

   protected override void OnModelCreating(ModelBuilder modelBuilder) =>
      modelBuilder.ApplyConfigurationsFromAssembly(typeof(PangoContext).Assembly);
}
