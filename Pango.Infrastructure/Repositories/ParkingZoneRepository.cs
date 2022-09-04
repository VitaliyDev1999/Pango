using Microsoft.EntityFrameworkCore;
using Pango.Domain.Entities;
using Pango.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pango.Infrastructure.Repositories;

public class ParkingZoneRepository : IParkingZoneRepository
{
    private readonly PangoContext _dbContext;

    public ParkingZoneRepository(PangoContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<ParkingZone>> GetAllParkingZonesAsync()
    {
        return await _dbContext.ParkingZone.ToArrayAsync();
    }
}
