using Microsoft.EntityFrameworkCore;
using Pango.Infrastructure;
using System;

namespace Pango.Test.Unit;

public class MemoryDbContext : PangoContext
{
    public MemoryDbContext()
            : base(new DbContextOptions<PangoContext>())
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
        base.OnConfiguring(optionsBuilder);
    }
}
